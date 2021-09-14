namespace MA_Service.Models.ArtistModels
{
    using Newtonsoft.Json;

    public class LastFmArtistBioResponse
    {
        [JsonProperty("artist")]
        public LastFmArtistsBio Artist { get; set; }
    }
}
