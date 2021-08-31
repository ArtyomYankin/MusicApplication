namespace MA_Service.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MA_Data;

    class LastFmTopAlbums
    {
        [JsonProperty("album")]
        public List<LastFmTopAlbum> Album { get; set; }
    }
}
