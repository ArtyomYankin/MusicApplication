namespace MA_Service
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class LastFmArtists
    {
        [JsonProperty("artist")]
        public List<LastFmArtist> LastFmArtist { get; set; }
    }
}
