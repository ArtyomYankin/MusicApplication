namespace MA_Repository
{
    using MA_Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IAlbumRepository<T> where T : Album
    {

        IEnumerable<Album> GetAllById(int entityId);
    }
}
