using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class OperatingSystem : Page
    {
        public OperatingSystem()
        {
            InitializeComponent();
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            if (OSSelectionBox != null && WindowsOS.IsChecked == true)
            {
                OSSelectionBox.IsEnabled = false;
            }
            if (OSSelectionBox != null && LinuxOS.IsChecked == true)
            {
                OSSelectionBox.IsEnabled = false;
            }
            if (OSSelectionBox != null && OtherOS.IsChecked == true)
            {
                OSSelectionBox.IsEnabled = true;
            }
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (OtherOS.IsChecked == true)
            {
                _ = Frame.Navigate(typeof(NameVirtualMachine), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }
    }
}
