using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.VMSettingsPages
{
    public sealed partial class Options : Page
    {
        public Options()
        {
            InitializeComponent();
        }
        private void OptionsNavView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            NavigationViewItemBase item = args.InvokedItemContainer;
            switch (item.Name)
            {
                case "General":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Power":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "SharedFolders":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Snapshots":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "NetworkAdapter":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "GuestIsolation":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "AccessControl":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "VMsTools":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "VNCConnections":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Unity":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "ApplianceView":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Autologin":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
                    break;
                case "Advanced":
                    _ = OptionsFrame.Navigate(typeof(NotAvailable));
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
            _ = OptionsFrame.Navigate(typeof(NotAvailable));
        }
        private void OptionsNavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem selectedItem)
            {
                switch (selectedItem.Tag)
                {
                    case "General":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Power":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "SharedFolders":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Snapshots":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "NetworkAdapter":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "GuestIsolation":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "AccessControl":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "VMsTools":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "VNCConnections":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Unity":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "ApplianceView":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Autologin":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Advanced":
                        _ = OptionsFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                }
            }
        }
    }
}