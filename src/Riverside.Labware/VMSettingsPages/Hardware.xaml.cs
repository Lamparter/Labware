using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using Riverside.Labware.Dialogs;

namespace Riverside.Labware.VMSettingsPages
{
    public sealed partial class Hardware : Page
    {
        private Window m_window;
        public Hardware()
        {
            this.InitializeComponent();
        }
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            m_window = new FeatureNotAvailable();
            m_window.Activate();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            m_window = new FeatureNotAvailable();
            m_window.Activate();
        }
        private void HardwareNavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem selectedItem)
            {
                switch (selectedItem.Tag)
                {
                    case "Memory":
                        HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Processors":
                        HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "HardDisk":
                        HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "CDDVD":
                        HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "NetworkAdapter":
                        HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "USBController":
                        HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "SoundCard":
                        HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Display":
                        HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                }
            }
        }
    }
}