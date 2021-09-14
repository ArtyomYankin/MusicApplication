namespace MA_Service
{
    using Newtonsoft.Json;

    public class LastFmArtistResponse
    {
        [JsonProperty("artists")]
        public LastFmArtists LastFmArtists { get; set; }
    }
}
