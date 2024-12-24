using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class OperatingSystem : Page
    {
        public OperatingSystem()
        {
            this.InitializeComponent();
        }
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            if (this.OSSelectionBox != null && this.WindowsOS.IsChecked == true)
            {
                this.OSSelectionBox.IsEnabled = false;
            }
            if (this.OSSelectionBox != null && this.LinuxOS.IsChecked == true)
            {
                this.OSSelectionBox.IsEnabled = false;
            }
            if (this.OSSelectionBox != null && this.OtherOS.IsChecked == true)
            {
                this.OSSelectionBox.IsEnabled = true;
            }
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.OtherOS.IsChecked == true)
            {
                this.Frame.Navigate(typeof(NameVirtualMachine), null, new SuppressNavigationTransitionInfo());
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
    }
}
