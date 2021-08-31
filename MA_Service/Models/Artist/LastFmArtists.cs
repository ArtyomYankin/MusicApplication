namespace MA_Service
{
    using MA_Data;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LastFmArtists
    {
        [JsonProperty("artist")]
        public List<LastFmArtist> LastFmArtist { get; set; }
    }
}
