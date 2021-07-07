using Newtonsoft.Json;
using System;

namespace Rick
{
    /// <summary>
    /// Defines someone who has starred in Rick and Morty
    /// </summary>
    public sealed class Character : CanError
    {
        internal Character() { }
        /// <summary>
        /// The id to get this character by
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// The name of this character
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The status of this character, whether they be living, dead, or unknown
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// The species this character belongs to 
        /// </summary>
        public string Species { get; set; }
        /// <summary>
        /// The type of this character
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The gender of this character, whether they be Female, Male, Genderless, or Unknown
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// A direct image of this character | 300x300
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// The direct URL to this character
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// When this character was created
        /// </summary>
        public string Created { get; set; }

        /// <summary>
        /// The last <see cref="Place"/> this character is known to be
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Where this character came from
        /// </summary>
        public Location Origin { get; set; }

        /// <summary>
        /// The episodes this character stars in
        /// </summary>
        [JsonProperty("Episode")]
        public string[] Episodes { get; set; }

        /// <summary>
        /// The <see cref="Created"/> formated to be a <seealso cref="DateTime"/> value
        /// </summary>
        public DateTime DateCreated => DateTime.Parse(Created);
    }
}
