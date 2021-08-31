namespace MA_Service.ArtistService
{
    using MA_Data;
    using MA_Repository;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArtistService : IArtistService
    {
        private readonly IRepository<Artist> _artistRepository;
        public ArtistService (IRepository<Artist> artistRepository)
        {
            _artistRepository = artistRepository;
        }
        public Artist Get(int id)
        {
            return _artistRepository.Get(id);
        }

        public IEnumerable<Artist> GetAll()
        {
            return _artistRepository.GetAll();
        }
    }
}
