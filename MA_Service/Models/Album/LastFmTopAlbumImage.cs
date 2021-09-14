using Newtonsoft.Json;

namespace MA_Service
{
    public class LastFmTopAlbumImage
    {
        [JsonProperty("#text")]
        public string ImageUrl { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }
        public int AlbumId { get; set; }
    }
}

