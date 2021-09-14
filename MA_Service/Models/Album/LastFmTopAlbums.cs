namespace MA_Service.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    class LastFmTopAlbums
    {
        [JsonProperty("album")]
        public List<LastFmTopAlbum> Album { get; set; }
    }
}
