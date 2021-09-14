namespace MA_Service.Models.ArtistModels
{
    using Newtonsoft.Json;

    public class LastFmArtistBio
    {

        [JsonProperty("content")]
        public string Biography { get; set; }


        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}
