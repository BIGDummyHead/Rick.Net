namespace Rick
{
    /// <summary>
    /// A Location in the Rick and Morty universe
    /// </summary>
    public sealed class Location : CanError
    {
        internal Location() { }
        /// <summary>
        /// The id to find this location by
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// The name of this location
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// This location's type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The dimension this location resides in
        /// </summary>
        public string Dimension { get; set; }
        /// <summary>
        /// The people who live in this dimension
        /// </summary>
        public string[] Residents { get; set; }
        /// <summary>
        /// A link to view this dimension.
        /// </summary>
        public string URL { get; set; }
    }
}