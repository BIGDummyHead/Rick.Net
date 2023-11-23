using Newtonsoft.Json;
using System;

namespace Rick
{
    /// <summary>
    /// An Episode that was premieried to Adult Swim
    /// </summary>
    public sealed class Episode : CanError
    {
        internal Episode() { }

        /// <summary>
        /// An ID to find the Episode
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// The name of the episode
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// When this Episode aired 
        /// </summary>
        [JsonProperty("air_date")]
        public string AirDate { get; set; }
        /// <summary>
        /// The direct code for this episode
        /// </summary>
        [JsonProperty("episode")]
        public string EpisodeCode { get; set; }
        /// <summary>
        /// The characters seen in this episode.
        /// </summary>
        public string[] Characters { get; set; }
        /// <summary>
        /// A URL to the information of this episode
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// When this episode was created
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// The <see cref="Created"/> in a <seealso cref="DateTime"/> format
        /// </summary>
        public DateTime DateCreated => DateTime.Parse(Created);
        /// <summary>
        /// The <see cref="AirDate"/> in a <seealso cref="DateTime"/> format
        /// </summary>
        public DateTime AirDateTime => DateTime.Parse(AirDate);
    }
}
