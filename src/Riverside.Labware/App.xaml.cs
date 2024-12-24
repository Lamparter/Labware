using Microsoft.UI.Xaml;
using System.Threading.Tasks;
using WinUIEx;

namespace Riverside.Labware
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
        protected override async void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            LoadingWindow loadingwindow = new();
            m_window = new MainWindow();
            _ = loadingwindow.Show();
            await Task.Delay(500);
            m_window.Activate();
        }
        public static WindowEx m_window;
        public static WindowEx currentWizardWin;
    }
}
