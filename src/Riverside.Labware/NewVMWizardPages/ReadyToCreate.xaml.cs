using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class ReadyToCreate : Page
    {
        public ReadyToCreate()
        {
            InitializeComponent();
        }
        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            App.currentWizardWin.Close();
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
