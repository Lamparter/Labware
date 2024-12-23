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
    public sealed partial class NameVirtualMachine : Page
    {
        public NameVirtualMachine()
        {
            this.InitializeComponent();
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (Main.TypeCustom.IsChecked == true)
            {
                this.Frame.Navigate(typeof(ProcessorConfiguration), null, new SuppressNavigationTransitionInfo());
            }
            else
            {
                this.Frame.Navigate(typeof(DiskCapacity), null, new SuppressNavigationTransitionInfo());
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
