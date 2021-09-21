using Microsoft.AspNetCore.Mvc;
using MA_Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MA_Service.ArtistService;
using System;
using MA_Service;

namespace MusicApp.Controllers
{
    [Route("api/artists")]
    [ApiController]
    public class ArtistController : Controller
    {
        private readonly IArtistService _artistService;
        private readonly ILastFmArtistService _lastFmArtistService;
        private readonly ILastFmAlbumService _lastFmAlbumService;
        private readonly string lastFmApiKey = Environment.GetEnvironmentVariable("lastFmKey");
        public ArtistController(IArtistService artistService, ILastFmArtistService lastFmArtistService, ILastFmAlbumService lastFmAlbumService)
        {
            _artistService = artistService;
            _lastFmArtistService = lastFmArtistService;
            _lastFmAlbumService = lastFmAlbumService;
        }

        [HttpGet]
        public async Task<IEnumerable<Artist>> Get()
        {
            var artists = _artistService.GetAll();
            if (!artists.Any())
            {
                await GetArtistAsync();
            }
            //foreach (var item in artists)
            //{
            //    await _lastFmAlbumService.MapAlbums(lastFmApiKey, item.Name, item.Id);
            //}
            return artists;
        }

        [HttpGet("{id}")]
        public async Task<Artist> Get(int id)
        {
            Artist artist = _artistService.Get(id);
           await _lastFmAlbumService.MapAlbums(lastFmApiKey, artist.Name, artist.Id);
            return artist;
        }
        public async Task<IActionResult> GetArtistAsync()
        {
            await _lastFmArtistService.MapArtists(lastFmApiKey) ;
            return Ok();
        }
    }
}