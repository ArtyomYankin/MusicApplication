using MA_Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MA_Service
{
    public interface ILastFmArtistService
    {
        Task<IEnumerable<LastFmArtist>> GetArtistsAsync(string key);
        // Task<LastFmArtistBio> GetArtistBiosAsync(string key, string name);
        Task<Artist> MapArtists(string key);
        Task<string> MapArtistsBiosAsync(string key, string name);
    }
}
