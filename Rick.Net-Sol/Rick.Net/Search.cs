using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Rick
{
    /// <summary>
    /// Used to Get Information using the API from https://rickandmortyapi.com/
    /// </summary>
    public static class Search
    {
        /// <summary>
        /// Get <see cref="Multiple{T}"/> of <seealso cref="Location"/>
        /// </summary>
        /// <param name="page">The page number to get info from</param>
        /// <returns></returns>
        public static async Task<Multiple<Location>> GetAllLocationsAsync(int page = 1)
        {
            return await GetAllOf<Location>("location", page);
        }
        /// <summary>
        /// Get <see cref="Multiple{T}"/> of <seealso cref="Character"/>
        /// </summary>
        /// <param name="page">The page number to get info from</param>
        /// <returns></returns>
        public static async Task<Multiple<Character>> GetAllCharactersAsync(int page = 1)
        {
            return await GetAllOf<Character>("character", page);
        }
        /// <summary>
        /// Get <see cref="Multiple{T}"/> of <seealso cref="Episode"/>
        /// <param name="page">The page number to get info from</param>
        /// <returns></returns>
        /// </summary>
        public static async Task<Multiple<Episode>> GetAllEpisodesAsync(int page = 1)
        {
            return await GetAllOf<Episode>("episode", page);
        }

        /// <summary>
        /// Get <see cref="Multiple{T}"/> of <seealso cref="Episode"/> | Filtered
        /// <param name="page">The page number to get info from</param>
        /// <param name="episodeName">The name of the Episode - Can Leave Null</param>
        /// <param name="episodeCode">The episode code - Can Leave Null</param>
        /// <returns></returns>
        ///</summary>
        public static async Task<Multiple<Episode>> GetEpisodeAsync(int page = 1, string episodeName = null, string episodeCode = null)
        {
            string filter = $"https://rickandmortyapi.com/api/episode/?page={page}";

            if (episodeName != null)
                filter += $"&name={episodeName}";

            if (episodeCode != null)
                filter += $"&episode={episodeCode}";

            string json = await (await ApiRequester.RequestAPIAsync(filter, ApiRequester.RequestType.Get)).Content.ReadAsStringAsync();

            Multiple<Episode> x = JsonConvert.DeserializeObject<Multiple<Episode>>(json);

            return x;
        }

        /// <summary>
        /// Get <see cref="Multiple{T}"/> of <seealso cref="Location"/> | Filtered
        /// </summary>
        /// <param name="page">The page to get information from</param>
        /// <param name="name">The name of the Location</param>
        /// <param name="type">The type of the location</param>
        /// <param name="dimension">The dimension the location resides in</param>
        /// <returns></returns>
        public static async Task<Multiple<Location>> GetLocationAsync(int page = 1, string name = null, string type = null, string dimension = null)
        {
            string filter = $"https://rickandmortyapi.com/api/location/?page={page}";

            if (name != null)
                filter += $"&name={name}";

            if (type != null)
                filter += $"&type={type}";

            if (dimension != null)
                filter += $"&dimension={dimension}";

            string json = await (await ApiRequester.RequestAPIAsync(filter, ApiRequester.RequestType.Get)).Content.ReadAsStringAsync();

            Multiple<Location> x = JsonConvert.DeserializeObject<Multiple<Location>>(json);

            return x;
        }
        /// <summary>
        /// Get <see cref="Multiple{T}"/> of <seealso cref="Character"/> | Filtered
        /// </summary>
        /// <param name="page">The page to get information from</param>
        /// <param name="name">The name of the character</param>
        /// <param name="status">The status of this character</param>
        /// <param name="species">The speicies of this character</param>
        /// <param name="type">The type of this character</param>
        /// <param name="gender">The gender of the character</param>
        /// <returns></returns>
        public static async Task<Multiple<Character>> GetCharacterAsync(int page = 1, string name = null, Status status = default, string species = null, string type = null, Gender gender = default)
        {
            string filter = $"https://rickandmortyapi.com/api/character/?page={page}";

            if (name != null)
                filter += $"&name={name}";

            if (status != default)
                filter += $"&status={status}";

            if (species != null)
                filter += $"&species={species}";

            if (type != null)
                filter += $"&type={type}";

            if (gender != default)
                filter += $"&gender={gender}";

            string json = await (await ApiRequester.RequestAPIAsync(filter, ApiRequester.RequestType.Get)).Content.ReadAsStringAsync();

            Multiple<Character> x = JsonConvert.DeserializeObject<Multiple<Character>>(json);

            return x;
        }

        /// <summary>
        /// Get an <see cref="Episode"/> by it's ID
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        public static async Task<Episode> GetEpisodeAsync(int id)
        {
            return await GetByIdAsync<Episode>("episode", id);
        }
        /// <summary>
        /// Get an <see cref="Location"/> by it's ID
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        public static async Task<Location> GetLocationAsync(int id)
        {
            return await GetByIdAsync<Location>("location", id);
        }
        /// <summary>
        /// Get an <see cref="Character"/> by it's ID
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns></returns>
        public static async Task<Character> GetCharacterAsync(int id)
        {
            return await GetByIdAsync<Character>("character", id);
        }

        /// <summary>
        /// <see cref="GetCharacterAsync(int, string, Status, string, string, Gender)"/>
        /// </summary>
        /// <param name="page"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="species"></param>
        /// <param name="type"></param>
        /// <param name="gender"></param>
        /// <returns></returns>
        public static Multiple<Character> GetCharacter(int page = 1, string name = null, Status status = default, string species = null, string type = null, Gender gender = default)
        {
            return GetCharacterAsync(page, name, status, species, type, gender).GetAwaiter().GetResult();
        }
        /// <summary>
        /// <see cref="GetLocationAsync(int, string, string, string)"/>
        /// </summary>
        /// <param name="page"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="dimension"></param>
        /// <returns></returns>
        public static Multiple<Location> GetLocation(int page = 1, string name = null, string type = null, string dimension = null)
        {
            return GetLocationAsync(page, name, type, dimension).GetAwaiter().GetResult();
        }
        /// <summary>
        /// <see cref="GetEpisodeAsync(int, string, string)"/>
        /// </summary>
        /// <param name="page"></param>
        /// <param name="episodeName"></param>
        /// <param name="episodeCode"></param>
        /// <returns></returns>
        public static Multiple<Episode> GetEpisode(int page = 1, string episodeName = null, string episodeCode = null)
        {
            return GetEpisodeAsync(page, episodeName, episodeCode).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <see cref="GetAllEpisodesAsync(int)"/>
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Multiple<Episode> GetAllEpisodes(int page = 1)
        {
            return GetAllEpisodesAsync(page).GetAwaiter().GetResult();
        }
        /// <summary>
        /// <see cref="GetAllCharactersAsync(int)"/>
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Multiple<Character> GetAllCharacters(int page = 1)
        {
            return GetAllCharactersAsync(page).GetAwaiter().GetResult();
        }
        /// <summary>
        /// <see cref="GetAllLocationsAsync(int)"/>
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Multiple<Location> GetAllLocations(int page = 1)
        {
            return GetAllLocationsAsync(page).GetAwaiter().GetResult();
        }

        /// <summary>
        /// <see cref="GetEpisodeAsync(int)"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Episode GetEpisode(int id)
        {
            return GetEpisodeAsync(id).GetAwaiter().GetResult();
        }
        /// <summary>
        /// <see cref="GetLocationAsync(int)"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Location GetLocation(int id)
        {
            return GetLocationAsync(id).GetAwaiter().GetResult();
        }
        /// <summary>
        /// <see cref="GetCharacterAsync(int)"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Character GetCharacter(int id)
        {
            return GetCharacterAsync(id).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the base API used 
        /// </summary>
        /// <returns></returns>
        public static async Task<BaseAPI> GetBaseAsync()
        {
            string json = await (await ApiRequester.RequestAPIAsync("https://rickandmortyapi.com/api/", ApiRequester.RequestType.Get)).Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BaseAPI>(json);
        }

        /// <summary>
        /// Get the base API used
        /// </summary>
        /// <returns></returns>
        public static BaseAPI GetBase()
        {
            return GetBaseAsync().GetAwaiter().GetResult();
        }

        private static async Task<T> GetByIdAsync<T>(string name, int id) where T : class
        {
            string apireq = $"https://rickandmortyapi.com/api/{name}/{id}";

            string jsonReq = await (await ApiRequester.RequestAPIAsync(apireq, ApiRequester.RequestType.Get)).Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(jsonReq);
        }

        /// <summary>
        /// Get the content of a URL : Sends a GET Request
        /// </summary>
        /// <param name="url">The absolute URL</param>
        /// <returns></returns>
        public static async Task<string> GetContentAsync(string url)
        {
            return await (await ApiRequester.RequestAPIAsync(url, ApiRequester.RequestType.Get)).Content.ReadAsStringAsync();
        }

        /// <summary>
        /// Use a link gotten that leads to a <see cref="Episode"/>, <seealso cref="Location"/>, or <seealso cref="Character"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="url">Absolute URL</param>
        /// <returns></returns>
        public static async Task<T> UseLink<T>(string url) where T : CanError
        {
            string json = await GetContentAsync(url);

            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Get the content of a URL : Sends a GET Request
        /// </summary>
        /// <param name="url">The absolute URL</param>
        /// <returns></returns>
        public static string GetContent(string url)
        {
            return GetContentAsync(url).GetAwaiter().GetResult();
        }

        private static async Task<Multiple<T>> GetAllOf<T>(string apiName, int page) where T : class
        {
            if (page < 1)
                return null;

            string apireq = $"https://rickandmortyapi.com/api/{apiName}/?page={page}";

            string json = await (await ApiRequester.RequestAPIAsync(apireq, ApiRequester.RequestType.Get)).Content.ReadAsStringAsync();

            Multiple<T> x = JsonConvert.DeserializeObject<Multiple<T>>(json);
            return x;
        }
    }
}
