namespace MA_Service
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LastFmArtistResponse
    {
        [JsonProperty("artists")]
        public LastFmArtists LastFmArtists { get; set; }
    }
}
