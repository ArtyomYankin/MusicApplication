using Newtonsoft.Json;
using System.Collections.Generic;

namespace MA_Service
{
    public class LastFmTopAlbum
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("playcount")]
        public long Playcount { get; set; }

        [JsonProperty("artist")]
        public LastFmArtist Artist { get; set; }

        [JsonProperty("image")]
        public List<LastFmTopAlbumImage> Image { get; set; }
        public int AlbumArtistId { get; set; }
    }
}
