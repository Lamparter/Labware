using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace VMsApp.NewVMWizardPages
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
