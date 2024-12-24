using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Riverside.Labware.Wizards;
using System;
using System.Runtime.InteropServices;
using WinUIEx;

namespace Riverside.Labware.Views
{
    public sealed partial class HomePage : Page
    {
        public static void CreateModalWindow(WindowEx parentWindow, WindowEx childWindow, bool summonWindowAutomatically = true, bool blockInput = false)
        {
            nint hWndChildWindow = WinRT.Interop.WindowNative.GetWindowHandle(childWindow);
            nint hWndParentWindow = WinRT.Interop.WindowNative.GetWindowHandle(parentWindow);
            _ = SetWindowLong(hWndChildWindow, GWL_HWNDPARENT, hWndParentWindow);
            (childWindow.AppWindow.Presenter as OverlappedPresenter).IsModal = true;
            if (blockInput == true)
            {
                _ = EnableWindow(hWndParentWindow, false);
                childWindow.Closed += ChildWindow_Closed;
                void ChildWindow_Closed(object sender, Microsoft.UI.Xaml.WindowEventArgs args)
                {
                    _ = EnableWindow(hWndParentWindow, true);
                }
            }
            if (summonWindowAutomatically == true)
            {
                _ = childWindow.Show();
            }
        }
        private static nint SetWindowLong(nint hWnd, int nIndex, nint dwNewLong)
        {
            return nint.Size == 4 ? SetWindowLongPtr32(hWnd, nIndex, dwNewLong) : SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
        }
        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool EnableWindow(nint hWnd, bool bEnable);

        private const int GWL_HWNDPARENT = -8;

        [DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLong")]
        private static extern nint SetWindowLongPtr32(nint hWnd, int nIndex, nint dwNewLong);

        [DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLongPtr")]
        private static extern nint SetWindowLongPtr64(nint hWnd, int nIndex, nint dwNewLong);
        public HomePage()
        {
            InitializeComponent();
        }
        private void CreateVMButton_Click(object sender, RoutedEventArgs e)
        {
            NewVMWizard logWin = new();
            CreateModalWindow(App.m_window, logWin, true, true);
            App.currentWizardWin = logWin;
        }
    }
}
