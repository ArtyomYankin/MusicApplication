using AutoMapper;
using MA_Data;
using MA_Repository;
using MA_Service.Models.ArtistModels;
using Nancy.Json;
using Nancy.Json.Simple;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Service.ArtistService
{
    public class LastFmArtistService : ILastFmArtistService
    {
        private readonly IRepository<Artist> _artistRepository;
        private readonly IMapper _mapper;
        public LastFmArtistService(IMapper mapper, IRepository<Artist> artistRepository)
        {
            _artistRepository = artistRepository;
            _mapper = mapper;
        }

        public async Task<LastFmArtistBio> GetArtistBiosAsync(string key, string name)
        {
            var client = new RestClient("https://ws.audioscrobbler.com/2.0/?method=artist.getinfo&artist=" + name + "&api_key=" + key + "&format=json");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                try
                {
                    LastFmArtistBioResponse lastFmArtistBioResponse = JsonConvert.DeserializeObject<LastFmArtistBioResponse>(response.Content);
                    LastFmArtistBio lastFmArtistBio = lastFmArtistBioResponse.Artist.Bio;

                    return lastFmArtistBio;
                }
                
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public async Task<IEnumerable<LastFmArtist>> GetArtistsAsync(string key)
        {
            var client = new RestClient("http://ws.audioscrobbler.com/2.0/?method=chart.gettopartists&api_key=" + key + "&format=json");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                LastFmArtistResponse lastFmArtistResponse = JsonConvert.DeserializeObject<LastFmArtistResponse>(response.Content);
                IEnumerable<LastFmArtist> lastFmArtists = lastFmArtistResponse.LastFmArtists.LastFmArtist;
                return lastFmArtists;
            }
            else
            {
                return null;
            }
        }
        public async Task<Artist> MapArtists(string ApiKey)
        {
            IEnumerable<LastFmArtist> lastFmArtists = await GetArtistsAsync(ApiKey);

            IEnumerable<Artist> artists = _mapper.Map<IEnumerable<Artist>>(lastFmArtists);
            foreach (var item in artists)
            {
                LastFmArtistBio lastFmArtistBio = null;
                var client = new RestClient("https://ws.audioscrobbler.com/2.0/?method=artist.getinfo&artist=" + item.Name + "&api_key=" + ApiKey + "&format=json");
                var request = new RestRequest(Method.GET);
                IRestResponse response = await client.ExecuteAsync(request);
                if (response.IsSuccessful)
                {
                    LastFmArtistBioResponse lastFmArtistBioResponse = JsonConvert.DeserializeObject<LastFmArtistBioResponse>(response.Content);
                    lastFmArtistBio = lastFmArtistBioResponse.Artist.Bio;
                }
                Artist artist =  _mapper.Map<Artist>(lastFmArtistBio);
                item.Biography = artist.Biography;
            }
            _artistRepository.AddAll(artists);
            return null;
        }

        public async Task<string> MapArtistsBiosAsync(string key, string name)
        {
            LastFmArtistBio lastFmArtistBio = null;
            var client = new RestClient("https://ws.audioscrobbler.com/2.0/?method=artist.getinfo&artist=" + name + "&api_key=" + key + "&format=json");
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                    LastFmArtistBioResponse lastFmArtistBioResponse = JsonConvert.DeserializeObject<LastFmArtistBioResponse>(response.Content);
                    lastFmArtistBio = lastFmArtistBioResponse.Artist.Bio;
            }
            Artist artist = _mapper.Map<Artist>(lastFmArtistBio);
            return artist.Biography;
        }
    }
}
