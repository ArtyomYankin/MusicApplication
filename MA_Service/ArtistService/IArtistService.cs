namespace MA_Service.ArtistService
{
    using MA_Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IArtistService
    {
        IEnumerable<Artist> GetAll();
        Artist Get(int id);
    }
}
