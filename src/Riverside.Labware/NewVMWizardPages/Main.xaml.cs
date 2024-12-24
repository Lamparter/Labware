using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class Main : Page
    {
        public static RadioButton TypeCustom { get; set; }
        public static RadioButton TypeTypical { get; set; }
        public Main()
        {
            this.InitializeComponent();

            TypeCustom = CustomRadioButton;
            TypeTypical = TypicalRadioButton;
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.TypicalRadioButton.IsChecked == true)
            {
                this.Frame.Navigate(typeof(Installation), null, new SuppressNavigationTransitionInfo());
            }
            if (this.CustomRadioButton.IsChecked == true)
            {
                this.Frame.Navigate(typeof(Compatibility), null, new SuppressNavigationTransitionInfo());
            }
        }
    }
}
