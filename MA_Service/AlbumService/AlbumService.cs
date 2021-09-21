namespace MA_Service.AlbumService
{
    using MA_Data;
    using MA_Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository<Album> _albumRepository;
        public AlbumService(IAlbumRepository<Album> albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public IEnumerable<Album> GetAll(int artistId)
        {
            return _albumRepository.GetAllById(artistId);
        }
    }
}
