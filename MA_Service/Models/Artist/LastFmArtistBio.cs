namespace MA_Service.Models.ArtistModels
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LastFmArtistBio
    {

        [JsonProperty("content")]
        public string Biography { get; set; }


        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}
