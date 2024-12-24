using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class Compatibility : Page
    {
        public Compatibility()
        {
            InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            _ = Frame.Navigate(typeof(Installation), null, new SuppressNavigationTransitionInfo());
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
