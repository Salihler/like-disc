using like_disc.Core.Contexts.HttpClients;
using like_disc.Core.Models;
using like_disc.Core.Services;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace like_disc.Service.Services.HttpServices
{
    public class SpotifyService<TEntity> : ISpotifyService<TEntity> where TEntity : class
    {
        private readonly HttpClient _client;

        public SpotifyService(HttpClient httpClient)
        {
            _client = httpClient;
            _client.BaseAddress = new Uri("https://api.spotify.com/v1/");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<TEntity> Get(string param, Token token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Access_Token); 
            
            return await _client.GetFromJsonAsync<TEntity>(nameof(TEntity) + $"/{param}");
        }
    }
}
