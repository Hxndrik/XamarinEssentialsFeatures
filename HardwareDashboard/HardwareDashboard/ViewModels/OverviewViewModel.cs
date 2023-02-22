using System.Collections.Generic;
using Xamarin.Forms;
using HardwareDashboard.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace HardwareDashboard.ViewModels
{
    class OverviewViewModel
    {
        /// <summary>
        /// Dashboard aka MainPage contains buttons to each individual Page
        /// Constructor fills XamarinEssentialFeatures list
        /// Constructor registers OpenFeatureCommand
        /// </summary>
        public OverviewViewModel()
        {
            List<string> pageStrings = new List<string>() { 
                "Flashlight", 
                "Battery", 
                "Web Browser", 
                "Connectivity",
                "Clipboard", 
                "Device Information"
            };
            foreach (var pageString in pageStrings)
            {
                XamarinEssentialFeatures.Add(new XamarinEssentialFeature() { FeatureName = pageString });
            }
            OpenFeatureCommand = new RelayCommand<string>(async (string param) => await OpenFeature(param));
        }
        /// <summary>
        /// Command interface for the press of a button in the overview to open a feature's (Xamarin Essentials) View
        /// </summary>
        public ICommand OpenFeatureCommand { get; private set; }

        /// <summary>
        /// List with all implemented features
        /// </summary>
        public ObservableCollection<XamarinEssentialFeature> XamarinEssentialFeatures { get; set; } = new ObservableCollection<XamarinEssentialFeature>();

        /// <summary>
        /// Method to open a view in the app
        /// </summary>
        /// <param name="nameOfPage"></param>
        /// <returns></returns>
        private async Task OpenFeature(string nameOfPage)
        {
            nameOfPage += "Page";
            await Shell.Current.GoToAsync(nameOfPage);
        }
    }

}
