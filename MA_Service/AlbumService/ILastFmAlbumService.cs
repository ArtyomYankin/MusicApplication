namespace MA_Service
{
    using MA_Data;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILastFmAlbumService
    {
        Task<IEnumerable<LastFmTopAlbum>> GetAlbumsAsync(string key, string artisName, int artistId);
        Task<IEnumerable<Album>> MapAlbums(string key, string artistName, int artistId);
    }
}
