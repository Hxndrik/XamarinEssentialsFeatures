using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;

namespace HardwareDashboard.ViewModels
{
    class WebBrowserViewModel : ObservableObject
    {
        public WebBrowserViewModel()
        {
            OpenBrwoserCommand = new RelayCommand<string>(async (string param) => await OpenBrowser(param));
        }
        /// <summary>
        /// Property for the entry field on the WebBrowserPage
        /// Two-Way Bind in XAML
        /// </summary>
        public string URLEntryFieldText { get; set; }

        /// <summary>
        /// Command interface for the OpenBrwoserCommand
        /// </summary>
        public ICommand OpenBrwoserCommand { get; private set; }

        /// <summary>
        /// Method that validates and or formats the <paramref name="param"/> to a valid URL
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        private async Task OpenBrowser(string param)
        {
            string defaulturl = "https://www.google.com/";
            string url = defaulturl;
            if (!(param is null) && param == "custom")
            {
                URLEntryFieldText = URLEntryFieldText?.Trim();
                if ((URLEntryFieldText is null) || URLEntryFieldText == "")
                {
                    return;
                }
                if (!URLEntryFieldText.ToLower().Contains("://"))
                {
                    URLEntryFieldText = "https://" + URLEntryFieldText;
                }
                if (!URLEntryFieldText.Contains("."))
                {
                    URLEntryFieldText += ".com";
                }
                url = URLEntryFieldText;


            }
            await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);

        }
    }
}
