using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class Compatibility : Page
    {
        public Compatibility()
        {
            this.InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Installation), null, new SuppressNavigationTransitionInfo());
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
