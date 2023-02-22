using Xamarin.Forms;

[assembly: ExportFont("NotoSans-Bold.ttf", Alias = "NotoSansBold")]
[assembly: ExportFont("NotoSans-Regular.ttf", Alias = "NotoSansRegular")]

namespace HardwareDashboard
{
    partial class App : Application
    {
        /// <summary>
        /// Constructor for the App.xaml.cs
        /// MainPage is set to new AppShell
        /// </summary>
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
