using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Rick.ApiRequester;

namespace Rick
{
    /// <summary>
    /// Defines a place in the Rick and Morty universe
    /// </summary>
    //public sealed class Place
    //{
    //    internal Place(JObject plce)
    //    {
    //        Name = plce.Value<string>("name");
    //        URL = plce.Value<string>("url");

    //        SetInfo();
    //    }

    //    private async void SetInfo()
    //    {
    //        var api = await RequestAPIAsync(URL, RequestType.Get);

    //        Info = JsonConvert.DeserializeObject<Location>(await api.Content.ReadAsStringAsync());
    //    }

    //    /// <summary>
    //    /// The name of this place
    //    /// </summary>
    //    public string Name { get; set; }
    //    /// <summary>
    //    /// The direct url to this place
    //    /// </summary>
    //    public string URL { get; set; }

    //    /// <summary>
    //    /// Information of the Place this character came from or where they were last seen
    //    /// </summary>
    //    public Location Info { get; private set; }
    //}
}