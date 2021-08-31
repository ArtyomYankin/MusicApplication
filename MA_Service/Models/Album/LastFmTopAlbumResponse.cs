namespace MA_Service.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LastFmTopAlbumResponse
    {
        [JsonProperty("topalbums")]
        public LastFmTopAlbums TopAlbums { get; set; }
    }
}
