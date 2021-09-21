namespace MA_Service.AlbumService
{
    using MA_Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAlbumService
    {
        IEnumerable<Album> GetAll(int artistId);
    }
}
