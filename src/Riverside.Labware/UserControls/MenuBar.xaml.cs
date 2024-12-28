using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml;
using Riverside.Labware.Dialogs;

namespace Riverside.Labware.UserControls
{
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();

            // ShowHideLibrary will be removed in a later version
            /*
            if (ShowHideLibrary.IsChecked == false)
            {
                ShowHideLibrary.IsChecked = true;
            } */
        }

        private void CreateNewVM_Click(object sender, RoutedEventArgs e)
        {
            VMCreationDialog logWin = new();
            MainWindow.CreateModalWindow(App.m_window, logWin, true, true);
            App.currentWizardWin = logWin;
        }

        private void NewWindow_Click(object sender, RoutedEventArgs e)
        {
            App.m_window.Activate();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            FeatureNotAvailableDialog logWin = new();
            MainWindow.CreateModalWindow(App.m_window, logWin, true, true);
        }

        private void VMSettings_Click(object sender, RoutedEventArgs e)
        {
            VMSettingsDialog logWin = new();
            MainWindow.CreateModalWindow(App.m_window, logWin, true, true);
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            AboutDialog logWin = new();
            MainWindow.CreateModalWindow(App.m_window, logWin, true, true);
        }

        private void Button_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void Button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.m_window.Close();
        }

        private void MessageLog_Click(object sender, RoutedEventArgs e)
        {
            MessageLogDialog logWin = new();
            MainWindow.CreateModalWindow(App.m_window, logWin, true, true);
        }

        private void VMMessageLog_Click(object sender, RoutedEventArgs e)
        {
            MessageLogDialog logWin = new();
            MainWindow.CreateModalWindow(App.m_window, logWin, true, true);
        }

        private void Preferences_Click(object sender, RoutedEventArgs e)
        {
            SettingsDialog logWin = new();
            MainWindow.CreateModalWindow(App.m_window, logWin, true, true);
        }

        private void HideFolderView_Click(object sender, RoutedEventArgs e)
        {
            // Methods removed as this will be removed in a later version

            /*
            FolderView.Visibility = Visibility.Collapsed;
            TabsView.Margin = new Thickness(0, 0, 0, 0);
            ShowHideFolderView.IsChecked = false;
            */
        }

        /*
        public static void UncheckShowHideLibrary()
        {
            ShowHideLibrary.IsChecked = false;
        } */

        private void ShowHideFolderView_Click(object sender, RoutedEventArgs e)
        {
            // Will be removed in a later version
            /*
            if (FolderView.Visibility == Visibility.Visible)
            {
                MainWindow.lFolderView.Visibility = Visibility.Collapsed;
                TabsView.Margin = new Thickness(0, 0, 0, 0);
                ShowHideFolderView.IsChecked = false;
            }
            else
            {
                FolderView.Visibility = Visibility.Visible;
                TabsView.Margin = new Thickness(0, 0, 0, 152);
                ShowHideFolderView.IsChecked = true;
            } */
        }
    }
}
