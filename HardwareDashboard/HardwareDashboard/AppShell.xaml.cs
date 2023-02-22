using HardwareDashboard.Views;
using Xamarin.Forms;

namespace HardwareDashboard
{
    partial class AppShell : Xamarin.Forms.Shell
    {
        /// <summary>
        /// Constructor for AppShell
        /// Registers routes for every Feature-View + Overview
        /// </summary>
        public AppShell()
        {

            //foreach class in namespace
            InitializeComponent();
            Routing.RegisterRoute(nameof(OverviewPage), typeof(OverviewPage));
            Routing.RegisterRoute(nameof(ClipboardPage), typeof(ClipboardPage));
            Routing.RegisterRoute(nameof(BatteryPage), typeof(BatteryPage));
            Routing.RegisterRoute(nameof(FlashlightPage), typeof(FlashlightPage));
            Routing.RegisterRoute(nameof(WebBrowserPage), typeof(WebBrowserPage));
            Routing.RegisterRoute(nameof(ConnectivityPage), typeof(ConnectivityPage));
            Routing.RegisterRoute(nameof(DeviceInformationPage), typeof(DeviceInformationPage));
        }
    }
}
