using like_disc.Core.Contexts.HttpClients;
using like_disc.Core.Models;
using like_disc.Core.Services;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace like_disc.Service.Services.HttpServices
{
    public class SpotifyService<TEntity> : SpotifyClient, ISpotifyService<TEntity> where TEntity : class
    {
        private readonly HttpClient _client;

        public SpotifyService(HttpClient httpClient) : base(httpClient)
        {
            _client = httpClient;
        }

        public async Task<TEntity> Get(string param, Token token)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Access_Token);

            var response = await _client.GetAsync(new Uri(_client.BaseAddress, $"{typeof(TEntity).Name.ToLower()}s/{param}"));

            if (response.IsSuccessStatusCode)
            {
                using (var stream = response.Content.ReadAsStringAsync())
                {
                    if (stream.IsCompletedSuccessfully)
                    {
                        TEntity album = JsonConvert.DeserializeObject<TEntity>(stream.Result);
                        return album;
                    }
                }
            }

            return null;
        }
    }
}
