using Newtonsoft.Json;
using System.Collections.Generic;

namespace MA_Service
{
    public class LastFmArtist
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playcount")]
        public long Playcount { get; set; }

        [JsonProperty("listeners")]
        public long Listeners { get; set; }

        [JsonProperty("image")]
        public List<LastFmArtistImage> Image { get; set; }
        public List<LastFmTopAlbum> Albums { get; set; }
    }
}
