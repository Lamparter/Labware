using Microsoft.UI.Xaml;
using System;
using System.Reflection;
using System.Threading.Tasks;
using WinUIEx;

namespace Riverside.Labware
{
    public sealed partial class LoadingWindow : Window
    {
        public LoadingWindow()
        {
            InitializeComponent();
            this.SetWindowSize(550, 300);
            ExtendsContentIntoTitleBar = true;
            this.SetIsMinimizable(false);
            this.SetIsResizable(false);
            this.SetIsMaximizable(false);
            this.CenterOnScreen();
            this.SetIsAlwaysOnTop(true);
            AppWindow.TitleBar.PreferredHeightOption = Microsoft.UI.Windowing.TitleBarHeightOption.Collapsed;
            try
            {
                AppWindow.SetIcon($"{AppContext.BaseDirectory}/Assets/AppTiles/StoreLogo.scale-400.png");
            }
            catch
            {

            }
            Title = "Loading...";

            CompilationText.Text = "Compilation date " + GetBuildDate(Assembly.GetExecutingAssembly());

            Run();
        }

        private static DateTime GetBuildDate(Assembly assembly)
        {
            BuildDateAttribute attribute = assembly.GetCustomAttribute<BuildDateAttribute>();
            return attribute != null ? attribute.DateTime : default;
        }

        public async void Run()
        {
            await Task.Delay(1000);

            Close();
        }
    }
}