namespace MA_Service.Models.ArtistModels
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LastFmArtistsBio
    {
        [JsonProperty("bio")]
        public LastFmArtistBio Bio { get; set; }    
    }
}
