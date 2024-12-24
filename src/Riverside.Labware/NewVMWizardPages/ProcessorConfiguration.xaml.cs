using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class ProcessorConfiguration : Page
    {
        public ProcessorConfiguration()
        {
            this.InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ReadyToCreate), null, new SuppressNavigationTransitionInfo());
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
