using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Linq;
using Xamarin.Essentials;

namespace HardwareDashboard.ViewModels
{
    public class ConnectivityViewModel : ObservableObject
    {
        /// <summary>
        /// Registers the ConnectivityChanged event
        /// </summary>
        public ConnectivityViewModel() {

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
        }

        private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            OnPropertyChanged(nameof(Type));
            OnPropertyChanged(nameof(ConnectedToWiFi));
            OnPropertyChanged(nameof(ConnectedToCelluar));
            OnPropertyChanged(nameof(ConnectedToBluetooth));

        }

        /// <summary>
        /// Returns the current NetworkAccess
        /// </summary>
        public string Type
        {
            get
            {
                return Connectivity.NetworkAccess.ToString();
            }
        }
        /// <summary>
        /// Returns wether the device is connected to a wifi network
        /// </summary>
        public bool ConnectedToWiFi
        {
            get
            {
                return Connectivity.ConnectionProfiles.Contains(ConnectionProfile.WiFi);
            }
        }
        /// <summary>
        /// Returns wether the device is connected to a celluar network
        /// </summary>
        public bool ConnectedToCelluar
        {
            get
            {
                return Connectivity.ConnectionProfiles.Contains(ConnectionProfile.Cellular);
            }
        }

        /// <summary>
        /// Returns wether the device is connected to a bluetooth device
        /// </summary>
        public bool ConnectedToBluetooth
        {
            get
            {
                return Connectivity.ConnectionProfiles.Contains(ConnectionProfile.Bluetooth);
            }
        }
    }
}
