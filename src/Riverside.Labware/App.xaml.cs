using Microsoft.UI.Xaml;
using System;
using System.Threading.Tasks;
using WinUIEx;

namespace Riverside.Labware
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
        }
        protected override async void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            LoadingWindow loadingwindow = new LoadingWindow();
            m_window = new MainWindow();
            loadingwindow.Show();
            await Task.Delay(500);
            m_window.Activate();
        }
        public static WindowEx m_window;
        public static WindowEx currentWizardWin;
    }
}
