namespace MA_Service
{
    using AutoMapper;
    using MA_Data;
    using MA_Service.Models.ArtistModels;

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
