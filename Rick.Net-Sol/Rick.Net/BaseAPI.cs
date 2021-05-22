namespace Rick
{
    /// <summary>
    /// The information of the Basic API request links.
    /// </summary>
    public sealed class BaseAPI
    {
        internal BaseAPI()
        {

        }

        /// <summary>
        /// A link to the API Request of Characters.
        /// </summary>
        public string Characters { get; set; }
        /// <summary>
        /// A link to the API Request of Locations.
        /// </summary>
        public string Locations { get; set; }
        ///<summary>
        /// A link to the API Request of Episodes.
        ///</summary>
        public string Episodes { get; set; }
    }
}
