using Newtonsoft.Json;

namespace Rick
{
    /// <summary>
    /// Only displayed when making a <see cref="Multiple{T}"/> request.
    /// </summary>
    public sealed class Info
    {
        internal Info() { }

        /// <summary>
        /// The count of objects in a category. Characters, Locations, and Episodes.
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// The amount of pages.
        /// </summary>
        public int Pages { get; set; }
        /// <summary>
        /// The next page
        /// <para>Can Be Null</para>
        /// </summary>
        public string Next { get; set; }
        /// <summary>
        /// The previous page
        /// <para>Can Be Null</para>
        /// </summary>

        [JsonProperty("prev")]
        public string Previous { get; set; }
    }
}
