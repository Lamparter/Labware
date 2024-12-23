using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Riverside.Labware.Wizards;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace Riverside.Labware.NewVMWizardPages
{
    public sealed partial class ReadyToCreate : Page
    {
        public ReadyToCreate()
        {
            this.InitializeComponent();
        }
        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            App.currentWizardWin.Close();
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
