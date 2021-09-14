namespace MA_Service.Models.ArtistModels
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class LastFmArtistsBio
    {
        [JsonProperty("bio")]
        public LastFmArtistBio Bio { get; set; }
        [JsonProperty("image")]
        public List<LastFmArtistImage> Images { get; set; }
    }
}
