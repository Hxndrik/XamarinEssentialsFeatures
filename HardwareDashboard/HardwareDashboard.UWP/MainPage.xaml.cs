namespace HardwareDashboard.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new HardwareDashboard.App());
        }
    }
}
