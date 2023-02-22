using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace HardwareDashboard.ViewModels
{
    class ClipboardViewModel : ObservableObject
    {
        /// <summary>
        /// Constructor registers the OnClipboardContentChanged event and reads the clipboard initially
        /// </summary>
        public ClipboardViewModel()
        {
            // Register for clipboard changes, be sure to unsubscribe when needed
            Clipboard.ClipboardContentChanged += OnClipboardContentChanged;

            Task.Run(async () =>
            {
                await ReadClipboard();
            }).Wait();
        }
        private string clipboardText;
        
        /// <summary>
        /// Property for the text in the clipboard
        /// </summary>
        public string ClipboardText
        {
            get
            {
                return clipboardText;
            }
            set
            {
                clipboardText = value;
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Reads the current clipboard
        /// </summary>
        /// <returns></returns>
        public async Task ReadClipboard()
        {
            ClipboardText = await Clipboard.GetTextAsync();
        }
        private async void OnClipboardContentChanged(object sender, EventArgs e)
        {
            await ReadClipboard();
        }
    }
}
