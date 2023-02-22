using CommunityToolkit.Mvvm.ComponentModel;
using Xamarin.Essentials;

namespace HardwareDashboard.ViewModels
{
    /// <summary>
    /// Returns information about the device
    /// </summary>
    class DeviceInformationViewModel : ObservableObject
    {

        /// <summary>
        /// Returns device model (e.g. 'iPhone 15 Pro')
        /// </summary>
        public string Model
        {
            get
            {
                return DeviceInfo.Model.ToString();
            }
        }
        /// <summary>
        /// Returns device manufacturer (e.g. 'Apple')
        /// </summary>
        public string Manufacturer
        {
            get
            {
                return DeviceInfo.Manufacturer.ToString();
            }
        }
        /// <summary>
        /// Returns device name (e.g. 'Hendriks iPhone')
        /// </summary>
        public string Name
        {
            get
            {
                return DeviceInfo.Name.ToString();
            }
        }
        /// <summary>
        /// Returns version number
        /// </summary>
        private string VersionString
        {
            get
            {
                return DeviceInfo.VersionString.ToString();
            }
        }
        /// <summary>
        /// Returns OS Name
        /// </summary>
        private string Platform
        {
            get
            {
                return DeviceInfo.Platform.ToString();
            }
        }
        /// <summary>
        /// Returns device type (e.g. 'Physical')
        /// </summary>
        public string DeviceType
        {
            get
            {
                return DeviceInfo.DeviceType.ToString();
            }
        }
        /// <summary>
        /// Returns OS Name + OS Version (e.g. 'iOS 16')
        /// </summary>
        public string OS
        {
            get
            {
                return Platform + " " + VersionString;
            }
        }
    }
}
