using CommunityToolkit.Mvvm.ComponentModel;
using Xamarin.Essentials;

namespace HardwareDashboard.ViewModels
{
    class BatteryViewModel : ObservableObject
    {
        /// <summary>
        /// Constructor which registers the BatteryInfoChanged event
        /// </summary>
        public BatteryViewModel()
        {
            // Register for battery changes, be sure to unsubscribe when needed
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        /// <summary>
        /// BatteryInfoChanged Event which triggers OnPropertyChanged on all properties in this class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            OnPropertyChanged(nameof(ChargeLevel));
            OnPropertyChanged(nameof(PowerSource));
            OnPropertyChanged(nameof(BatteryState));
        }

        /// <summary>
        /// Current charge from 0 - 100
        /// </summary>
        public string ChargeLevel
        {
            get
            {
                return GetChargeLevel();
            }
        }
        private string GetChargeLevel()
       {
            double chargeLevel = Battery.ChargeLevel;
            int chargeLevelInt = (int) (chargeLevel * 100);
            if (chargeLevelInt >= 0) {
                return chargeLevelInt.ToString();
            }
            else
            {
                return "NO BATTERY";
            }
        }

        /// <summary>
        /// Current battery charging state
        /// </summary>
        public string BatteryState
        {
            get
            {
                return GetBatteryState();
            }
        }
        private string GetBatteryState()
        {
            var state = Battery.State;

            return state.ToString();
        }

        /// <summary>
        /// Current power source
        /// </summary>
        public string PowerSource
        {
            get
            {
                return GetPowerSource();
            }
        }
        private string GetPowerSource()
        {
            var source = Battery.PowerSource;

            return source.ToString();
        }


    }
}
