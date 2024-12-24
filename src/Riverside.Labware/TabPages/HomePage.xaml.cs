using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Riverside.Labware.Wizards;
using System;
using System.Runtime.InteropServices;
using WinUIEx;

namespace Riverside.Labware.TabPages
{
    public sealed partial class HomePage : Page
    {
        public static void CreateModalWindow(WindowEx parentWindow, WindowEx childWindow, bool summonWindowAutomatically = true, bool blockInput = false)
        {
            IntPtr hWndChildWindow = WinRT.Interop.WindowNative.GetWindowHandle(childWindow);
            IntPtr hWndParentWindow = WinRT.Interop.WindowNative.GetWindowHandle(parentWindow);
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
        private static IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong)
        {
            return IntPtr.Size == 4 ? SetWindowLongPtr32(hWnd, nIndex, dwNewLong) : SetWindowLongPtr64(hWnd, nIndex, dwNewLong);
        }
        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool EnableWindow(IntPtr hWnd, bool bEnable);

        private const int GWL_HWNDPARENT = -8;

        [DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLong")]
        private static extern IntPtr SetWindowLongPtr32(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowLongPtr")]
        private static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
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
