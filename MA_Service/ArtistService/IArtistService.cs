namespace MA_Service.ArtistService
{
    using MA_Data;
    using System.Collections.Generic;

    public interface IArtistService
    {
        IEnumerable<Artist> GetAll();
        Artist Get(int id);
    }
}
