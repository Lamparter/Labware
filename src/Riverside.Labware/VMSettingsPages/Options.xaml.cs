using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.VMSettingsPages
{
    public sealed partial class Options : Page
    {
        public Options()
        {
            this.InitializeComponent();
        }
        private void OptionsNavView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            var item = args.InvokedItemContainer;
            switch (item.Name)
            {
                case "General":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Power":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "SharedFolders":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Snapshots":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "NetworkAdapter":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "GuestIsolation":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "AccessControl":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "VMsTools":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "VNCConnections":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Unity":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "ApplianceView":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Autologin":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Advanced":
                    OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
            }
        }
        private void OptionsNavView_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Microsoft.UI.Xaml.Controls.NavigationViewItemBase item in OptionsNavView.MenuItems)
            {
                if (item is Microsoft.UI.Xaml.Controls.NavigationViewItem && item.Tag?.ToString() == "General")
                {
                    OptionsNavView.SelectedItem = item;
                    break;
                }
            }
            OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void OptionsNavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem selectedItem)
            {
                switch (selectedItem.Tag)
                {
                    case "General":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Power":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "SharedFolders":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Snapshots":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "NetworkAdapter":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "GuestIsolation":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "AccessControl":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "VMsTools":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "VNCConnections":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Unity":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "ApplianceView":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Autologin":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Advanced":
                        OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                }
            }
        }
    }
}