using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
