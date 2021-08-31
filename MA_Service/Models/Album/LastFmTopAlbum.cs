using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
