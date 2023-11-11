using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace VMsApp.VMSettingsPages
{
    public sealed partial class Options : Page
    {
        public Options()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());

            GeneralButton.IsChecked = true;
            PowerButton.IsChecked = false;
            SharedFoldersButton.IsChecked = false;
            SnapshotsButton.IsChecked = false;
            AutoProtectButton.IsChecked = false;
        }
        private void GuestIsolationButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void AccessControlButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void VMsToolsButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void VNCConnectionsButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void UnityButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void ApplianceViewButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void AutologinButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void AdvancedButton_Click(object sender, RoutedEventArgs e)
        {
            this.OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void GeneralButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralButton.IsChecked = true;
            PowerButton.IsChecked = false;
            SharedFoldersButton.IsChecked = false;
            SnapshotsButton.IsChecked = false;
            AutoProtectButton.IsChecked = false;
        }
        private void GeneralButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                GeneralButton.IsChecked = true;
                PowerButton.IsChecked = false;
                SharedFoldersButton.IsChecked = false;
                SnapshotsButton.IsChecked = false;
                AutoProtectButton.IsChecked = false;
            }
        }
        private void GeneralButton_Checked(object sender, RoutedEventArgs e)
        {
            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralButton.IsChecked = false;
            PowerButton.IsChecked = true;
            SharedFoldersButton.IsChecked = false;
            SnapshotsButton.IsChecked = false;
            AutoProtectButton.IsChecked = false;
        }
        private void PowerButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                GeneralButton.IsChecked = false;
                PowerButton.IsChecked = true;
                SharedFoldersButton.IsChecked = false;
                SnapshotsButton.IsChecked = false;
                AutoProtectButton.IsChecked = false;
            }
        }
        private void PowerButton_Checked(object sender, RoutedEventArgs e)
        {
            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void SharedFoldersButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralButton.IsChecked = false;
            PowerButton.IsChecked = false;
            SharedFoldersButton.IsChecked = true;
            SnapshotsButton.IsChecked = false;
            AutoProtectButton.IsChecked = false;
        }
        private void SharedFoldersButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                GeneralButton.IsChecked = false;
                PowerButton.IsChecked = false;
                SharedFoldersButton.IsChecked = true;
                SnapshotsButton.IsChecked = false;
                AutoProtectButton.IsChecked = false;
            }
        }
        private void SharedFoldersButton_Checked(object sender, RoutedEventArgs e)
        {
            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void SnapshotsButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralButton.IsChecked = false;
            PowerButton.IsChecked = false;
            SharedFoldersButton.IsChecked = false;
            SnapshotsButton.IsChecked = true;
            AutoProtectButton.IsChecked = false;
        }
        private void SnapshotsButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                GeneralButton.IsChecked = false;
                PowerButton.IsChecked = false;
                SharedFoldersButton.IsChecked = false;
                SnapshotsButton.IsChecked = true;
                AutoProtectButton.IsChecked = false;
            }
        }
        private void SnapshotsButton_Checked(object sender, RoutedEventArgs e)
        {
            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void AutoProtectButton_Click(object sender, RoutedEventArgs e)
        {
            GeneralButton.IsChecked = false;
            PowerButton.IsChecked = false;
            SharedFoldersButton.IsChecked = false;
            SnapshotsButton.IsChecked = false;
            AutoProtectButton.IsChecked = true;
        }
        private void AutoProtectButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            e.Handled = true;

            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                GeneralButton.IsChecked = false;
                PowerButton.IsChecked = false;
                SharedFoldersButton.IsChecked = false;
                SnapshotsButton.IsChecked = false;
                AutoProtectButton.IsChecked = true;
            }
        }
        private void AutoProtectButton_Checked(object sender, RoutedEventArgs e)
        {
            if (OptionsFrame.CurrentSourcePageType != typeof(NotAvailable) && typeof(NotAvailable) != null)
            {
                OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
            }
        }
    }
}