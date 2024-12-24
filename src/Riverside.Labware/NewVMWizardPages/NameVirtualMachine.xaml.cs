using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class NameVirtualMachine : Page
    {
        public NameVirtualMachine()
        {
            InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            _ = Main.TypeCustom.IsChecked == true
                ? Frame.Navigate(typeof(ProcessorConfiguration), null, new SuppressNavigationTransitionInfo())
                : Frame.Navigate(typeof(DiskCapacity), null, new SuppressNavigationTransitionInfo());
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
