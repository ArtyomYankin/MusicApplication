using Newtonsoft.Json;

namespace MA_Service
{
    public class LastFmArtistImage
    {
        [JsonProperty("#text")]
        public string ImageUrl { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        public int ArtistId { get; set; }
    }
}
