using Newtonsoft.Json;

namespace Rick
{
    /// <summary>
    /// Defines an API request that can error!
    /// <para><see cref="DidError"/> to check if your request was not found!</para>
    /// </summary>
    public abstract class CanError
    {
        internal CanError() { }

        /// <summary>
        /// The error message if any
        /// </summary>
        [JsonProperty("error")]
        public string ErrorMessage { get; set; } = "";

        /// <summary>
        /// Is there an error message?
        /// </summary>
        public bool DidError => ErrorMessage != string.Empty;
    }
}
