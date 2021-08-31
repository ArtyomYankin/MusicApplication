namespace MA_Service
{
    using AutoMapper;
    using MA_Data;
    using MA_Service.Models.ArtistModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LastFmArtist, Artist>();
            CreateMap<LastFmArtistBio, Artist>();
            CreateMap<LastFmArtistImage, Artist>();
            CreateMap<LastFmTopAlbum, Album>();
        }
    
    }
}
