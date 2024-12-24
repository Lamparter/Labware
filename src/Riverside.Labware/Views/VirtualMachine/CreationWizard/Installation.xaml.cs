using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.Views.VirtualMachine.CreationWizard
{
    public sealed partial class Installation : Page
    {
        public Installation()
        {
            InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (InstallLaterCheck.IsChecked == true)
            {
                _ = Frame.Navigate(typeof(OperatingSystem), null, new SuppressNavigationTransitionInfo());
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
