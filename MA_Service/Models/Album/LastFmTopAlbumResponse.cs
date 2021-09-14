namespace MA_Service.Models
{
    using Newtonsoft.Json;

    class LastFmTopAlbumResponse
    {
        [JsonProperty("topalbums")]
        public LastFmTopAlbums TopAlbums { get; set; }
    }
}
