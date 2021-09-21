namespace MA_Repository
{
    using MA_Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AlbumRepository<T> : IAlbumRepository<T> where T : Album
    {
            private readonly ApplicationContext _context;
            private readonly DbSet<Album> _albumEntity;

        public AlbumRepository(ApplicationContext context)
        {
            _context = context;
            _albumEntity = _context.Set<Album>();
        }

        public IEnumerable<Album> GetAllById(int entityId)
        {
            return _albumEntity.AsEnumerable().Where(x => x.ArtistId == entityId);
        }
    }
}
