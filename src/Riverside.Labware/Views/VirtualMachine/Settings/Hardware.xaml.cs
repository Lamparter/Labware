using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using Riverside.Labware.Dialogs;

namespace Riverside.Labware.Views.VirtualMachine.Settings
{
    public sealed partial class Hardware : Page
    {
        private Window m_window;
        public Hardware()
        {
            InitializeComponent();
        }
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            m_window = new FeatureNotAvailableDialog();
            m_window.Activate();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            m_window = new FeatureNotAvailableDialog();
            m_window.Activate();
        }
        private void HardwareNavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem selectedItem)
            {
                switch (selectedItem.Tag)
                {
                    case "Memory":
                        _ = HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Processors":
                        _ = HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "HardDisk":
                        _ = HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "CDDVD":
                        _ = HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "NetworkAdapter":
                        _ = HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "USBController":
                        _ = HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "SoundCard":
                        _ = HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                    case "Display":
                        _ = HardwareFrame.Navigate(typeof(NotAvailable), null, new SuppressNavigationTransitionInfo());
                        break;
                }
            }
        }
    }
}