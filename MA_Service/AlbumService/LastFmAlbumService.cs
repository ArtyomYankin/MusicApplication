namespace MA_Service
{
    using AutoMapper;
    using MA_Data;
    using MA_Repository;
    using MA_Service.Models;
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LastFmAlbumService : ILastFmAlbumService
    {
        private readonly IRepository<Album> _albumRepository;
        private readonly IMapper _mapper;
        public LastFmAlbumService (IRepository<Album> albumRepository, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LastFmTopAlbum>> GetAlbumsAsync(string key, string artistName, int artistId)
        {
            var client = new RestClient("https://ws.audioscrobbler.com/2.0/?method=artist.gettopalbums&artist=" + artistName + "&api_key=" + key + "&format=json");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                LastFmTopAlbumResponse allAlbums = JsonConvert.DeserializeObject<LastFmTopAlbumResponse>(response.Content);
                IEnumerable<LastFmTopAlbum> albums = allAlbums.TopAlbums.Album;
                return albums;
            }
            return null;
        }

        public async Task<Album> MapAlbums(string key, string artistName, int artistId)
        {
            IEnumerable<LastFmTopAlbum> lastFmTopAlbums = await GetAlbumsAsync(key, artistName, artistId);
            IEnumerable<Album> albums = _mapper.Map<IEnumerable<Album>>(lastFmTopAlbums);
            int i = 1;
            foreach (var item in albums)
            {

                item.Id = i;
                item.ArtistId = artistId;
                i++;
            }
            _albumRepository.AddAll(albums);
            return null;
        }
    }
}
