using Microsoft.UI.Content;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media.Animation;
using Riverside.Labware.Helpers;
using Riverside.Labware.Core.PInvoke.Comctl32;
using Riverside.Labware.Core.PInvoke.User32;
using Riverside.Labware.Views.Settings;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Graphics;
using WinUIEx;
using WinUIEx.Messaging;

namespace Riverside.Labware
{
    public sealed partial class Preferences : WindowEx, INotifyPropertyChanged
    {
        private readonly SUBCLASSPROC mainWindowSubClassProc;
        private readonly SUBCLASSPROC inputNonClientPointerSourceSubClassProc;
        private readonly ContentCoordinateConverter contentCoordinateConverter;
        private readonly OverlappedPresenter overlappedPresenter;
        private bool _isWindowMaximized;
        public bool IsWindowMaximized
        {
            get => _isWindowMaximized;

            set
            {
                if (!Equals(_isWindowMaximized, value))
                {
                    _isWindowMaximized = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsWindowMaximized)));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly WindowMessageMonitor _msgMonitor;
        public Preferences()
        {
            InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            AppWindow.Resize(new SizeInt32(800, 700));
            this.CenterOnScreen();
            SetTitleBar(PreferencesWindowTitleBar);

            _msgMonitor = new WindowMessageMonitor(this);
            _msgMonitor.WindowMessageReceived += (_, e) =>
            {
                const int WM_NCLBUTTONDBLCLK = 0x00A3;
                if (e.Message.MessageId == WM_NCLBUTTONDBLCLK)
                {
                    // Disable double click on title bar to maximize window
                    e.Result = 0;
                    e.Handled = true;
                }
            };

            overlappedPresenter = AppWindow.Presenter as OverlappedPresenter;
            contentCoordinateConverter = ContentCoordinateConverter.CreateForWindowId(AppWindow.Id);

            mainWindowSubClassProc = new SUBCLASSPROC(MainWindowSubClassProc);
            _ = Comctl32Library.SetWindowSubclass((IntPtr)AppWindow.Id.Value, Marshal.GetFunctionPointerForDelegate(mainWindowSubClassProc), 0, IntPtr.Zero);

            IntPtr inputNonClientPointerSourceHandle = User32Library.FindWindowEx((IntPtr)AppWindow.Id.Value, IntPtr.Zero, "InputNonClientPointerSource", null);

            if (inputNonClientPointerSourceHandle != IntPtr.Zero)
            {
                inputNonClientPointerSourceSubClassProc = new SUBCLASSPROC(InputNonClientPointerSourceSubClassProc);
                _ = Comctl32Library.SetWindowSubclass((IntPtr)AppWindow.Id.Value, Marshal.GetFunctionPointerForDelegate(inputNonClientPointerSourceSubClassProc), 0, IntPtr.Zero);
            }

            AppWindow.Changed += OnAppWindowChanged;
        }
        private void OnSizeChanged(object sender, WindowSizeChangedEventArgs args)
        {
            if (TitlebarMenuFlyout.IsOpen)
            {
                TitlebarMenuFlyout.Hide();
            }

            if (overlappedPresenter is not null)
            {
                IsWindowMaximized = overlappedPresenter.State is OverlappedPresenterState.Maximized;
            }
        }
        private void OnAppWindowChanged(AppWindow sender, AppWindowChangedEventArgs args)
        {
            if (args.DidPositionChange)
            {
                if (TitlebarMenuFlyout.IsOpen)
                {
                    TitlebarMenuFlyout.Hide();
                }

                if (overlappedPresenter is not null)
                {
                    IsWindowMaximized = overlappedPresenter.State is OverlappedPresenterState.Maximized;
                }
            }
        }
        private void OnRestoreClicked(object sender, RoutedEventArgs args)
        {
            overlappedPresenter.Restore();
        }
        private void OnMoveClicked(object sender, RoutedEventArgs args)
        {
            MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
            if (menuItem.Tag is not null)
            {
                ((MenuFlyout)menuItem.Tag).Hide();
                _ = User32Library.SendMessage((IntPtr)AppWindow.Id.Value, WindowMessage.WM_SYSCOMMAND, 0xF010, 0);
            }
        }
        private void OnSizeClicked(object sender, RoutedEventArgs args)
        {
            MenuFlyoutItem menuItem = sender as MenuFlyoutItem;
            if (menuItem.Tag is not null)
            {
                ((MenuFlyout)menuItem.Tag).Hide();
                _ = User32Library.SendMessage((IntPtr)AppWindow.Id.Value, WindowMessage.WM_SYSCOMMAND, 0xF000, 0);
            }
        }
        private void OnMinimizeClicked(object sender, RoutedEventArgs args)
        {
            overlappedPresenter.Minimize();
        }
        private void OnMaximizeClicked(object sender, RoutedEventArgs args)
        {
            overlappedPresenter.Maximize();
        }
        private void OnCloseClicked(object sender, RoutedEventArgs args)
        {
            Close();
        }
        private IntPtr MainWindowSubClassProc(IntPtr hWnd, WindowMessage Msg, UIntPtr wParam, IntPtr lParam, uint uIdSubclass, IntPtr dwRefData)
        {
            if (Msg is WindowMessage.WM_SYSCOMMAND)
            {
                SYSTEMCOMMAND sysCommand = (SYSTEMCOMMAND)(wParam.ToUInt32() & 0xFFF0);

                if (sysCommand is SYSTEMCOMMAND.SC_MOUSEMENU)
                {
                    FlyoutShowOptions options = new()
                    {
                        Position = new Point(0, 15),
                        ShowMode = FlyoutShowMode.Standard
                    };
                    TitlebarMenuFlyout.ShowAt(null, options);
                    return 0;
                }
                else if (sysCommand is SYSTEMCOMMAND.SC_KEYMENU)
                {
                    FlyoutShowOptions options = new()
                    {
                        Position = new Point(0, 45),
                        ShowMode = FlyoutShowMode.Standard
                    };
                    TitlebarMenuFlyout.ShowAt(null, options);
                    return 0;
                }
            }

            return Comctl32Library.DefSubclassProc(hWnd, Msg, wParam, lParam);
        }
        private IntPtr InputNonClientPointerSourceSubClassProc(IntPtr hWnd, WindowMessage Msg, UIntPtr wParam, IntPtr lParam, uint uIdSubclass, IntPtr dwRefData)
        {
            switch (Msg)
            {
                case WindowMessage.WM_NCLBUTTONDOWN:
                    {
                        if (TitlebarMenuFlyout.IsOpen)
                        {
                            TitlebarMenuFlyout.Hide();
                        }
                        break;
                    }
                case WindowMessage.WM_NCRBUTTONUP:
                    {
                        if (wParam.ToUInt32() is 2 && Content is not null && Content.XamlRoot is not null)
                        {
                            PointInt32 screenPoint = new(lParam.ToInt32() & 0xFFFF, lParam.ToInt32() >> 16);
                            Point localPoint = contentCoordinateConverter.ConvertScreenToLocal(screenPoint);

                            FlyoutShowOptions options = new()
                            {
                                ShowMode = FlyoutShowMode.Standard,
                                Position = InfoHelper.SystemVersion.Build >= 22000 ? new Point(localPoint.X / Content.XamlRoot.RasterizationScale, localPoint.Y / Content.XamlRoot.RasterizationScale) : new Point(localPoint.X, localPoint.Y)
                            };

                            TitlebarMenuFlyout.ShowAt(null, options);
                        }
                        return 0;
                    }
            }
            return Comctl32Library.DefSubclassProc(hWnd, Msg, wParam, lParam);
        }
        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem selectedItem)
            {
                switch (selectedItem.Tag)
                {
                    case "Workspace":
                        _ = PreferencesFrame.Navigate(typeof(Workspace), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Input":
                        _ = PreferencesFrame.Navigate(typeof(Input), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "HotKeys":
                        _ = PreferencesFrame.Navigate(typeof(HotKeys), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Display":
                        _ = PreferencesFrame.Navigate(typeof(Display), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "USB":
                        _ = PreferencesFrame.Navigate(typeof(USB), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Updates":
                        _ = PreferencesFrame.Navigate(typeof(Updates), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Feedback":
                        _ = PreferencesFrame.Navigate(typeof(Feedback), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Memory":
                        _ = PreferencesFrame.Navigate(typeof(Memory), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Priority":
                        _ = PreferencesFrame.Navigate(typeof(Priority), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Devices":
                        _ = PreferencesFrame.Navigate(typeof(Devices), null, new SuppressNavigationTransitionInfo());
                        break;
                }
            }
        }
        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Microsoft.UI.Xaml.Controls.NavigationViewItemBase item in PreferencesNavView.MenuItems)
            {
                if (item is Microsoft.UI.Xaml.Controls.NavigationViewItem && item.Tag?.ToString() == "Workspace")
                {
                    PreferencesNavView.SelectedItem = item;
                    break;
                }
            }
            _ = PreferencesFrame.Navigate(typeof(Workspace), null, new SuppressNavigationTransitionInfo());
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
