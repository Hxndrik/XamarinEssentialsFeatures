using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;

namespace HardwareDashboard.ViewModels
{
    class FlashlightViewModel : ObservableObject
    {
        /// <summary>
        /// Command interface for the flashlight button
        /// </summary>
        public ICommand FlashlightCommand { get; private set; }

        /// <summary>
        /// Constructor which registers the FlashlightCommand
        /// </summary>
        public FlashlightViewModel()
        {
            FlashlightCommand = new RelayCommand<string>(async (string param) => await FlashlightCommandTask(param));
        }
        private async Task FlashlightCommandTask(string param)
        {
            if (param == "On")
            {
                await Flashlight.TurnOnAsync();
                
            }
            else if (param == "Off")
            {
                await Flashlight.TurnOffAsync();
            }
        }
    }
}

