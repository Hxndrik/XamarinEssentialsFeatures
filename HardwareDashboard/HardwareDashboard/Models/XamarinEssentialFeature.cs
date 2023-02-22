namespace HardwareDashboard.Models
{
    /// <summary>
    /// Model for each available feature on the overview
    /// </summary>
    public class XamarinEssentialFeature
    {
        /// <summary>
        /// The displayname of the feature
        /// </summary>
        public string FeatureName { get; set; }
        /// <summary>
        /// The name of the feature's ViewModel
        /// </summary>
        public string ViewName
        {
            get
            {
                return FeatureName.Replace(" ", "");
            }
        }
    }
}
