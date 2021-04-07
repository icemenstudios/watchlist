using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net.Http;
using WatchList.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace WatchList.Data
{
    public class ApiGetMoviesService
    {
        
        //initialize an empty root object
        RootObject objectBody = null;

        private readonly ApiSettings _apiSettings;

        public ApiGetMoviesService(IOptionsMonitor<ApiSettings> optionsMonitor)
        {
            _apiSettings = optionsMonitor.CurrentValue;
        }

        public async Task<List<Entertainment>> GetMovies(string searchTerm = "Avengers")
        {

            List<Entertainment> watcherList = null;
            HttpClient client = new();
            HttpRequestMessage request = new()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://movie-database-imdb-alternative.p.rapidapi.com/?s={ searchTerm }&page=1&r=json"),
                Headers =
            {
            { "x-rapidapi-key", _apiSettings.rapidapiKey },
            { "x-rapidapi-host", _apiSettings.rapidapiHost },
        },
            };


            using (HttpResponseMessage response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                objectBody = JsonConvert.DeserializeObject<RootObject>(body);
                if (objectBody.Response == "True")
                {
                    try
                    {
                        watcherList = new List<Entertainment>(objectBody.Search);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
                else
                {
                    watcherList = null;
                }



            }

            return watcherList;

        }

        public async Task<Entertainment> GetMovie(string id = "tt4154756")
        {

            Entertainment selectedMovie = null;
            HttpClient client = new();
            HttpRequestMessage request = new()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://movie-database-imdb-alternative.p.rapidapi.com/?i={id}&page=1&r=json"),
                Headers =
            {
            { "x-rapidapi-key", _apiSettings.rapidapiKey },
            { "x-rapidapi-host", _apiSettings.rapidapiHost },
        },
            };


            using (HttpResponseMessage response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                selectedMovie = JsonConvert.DeserializeObject<Entertainment>(body);
              
            }

            return selectedMovie;

        }
    }
}
