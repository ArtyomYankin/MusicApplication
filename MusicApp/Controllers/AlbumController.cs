using MA_Data;
using MA_Service.AlbumService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace MusicApp.Controllers
{
   
    [Route("api/albums")]
    [ApiController]
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }
        [HttpGet("{artistId}")]
        public async Task<IEnumerable<Album>> GetAll(int artistId)
        {
            var albums = _albumService.GetAll(artistId);
            return albums;
        }
    }
}
