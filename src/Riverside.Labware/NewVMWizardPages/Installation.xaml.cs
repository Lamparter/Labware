using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class Installation : Page
    {
        public Installation()
        {
            this.InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.InstallLaterCheck.IsChecked == true)
            {
                this.Frame.Navigate(typeof(OperatingSystem), null, new SuppressNavigationTransitionInfo());
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
