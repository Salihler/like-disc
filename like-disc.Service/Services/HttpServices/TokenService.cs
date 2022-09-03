using like_disc.Core.Contexts.HttpClients;
using like_disc.Core.Models;
using like_disc.Core.Services;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace like_disc.Service.Services.HttpServices
{
    public class TokenService : TokenClient, ITokenService
    {
        private readonly HttpClient _client;
        public TokenService(HttpClient client) : base(client)
        {
            _client = client;
        }

        public async Task<Token> GetToken()
        {

            var data = new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            };

            var response = await _client.PostAsync(_client.BaseAddress, new FormUrlEncodedContent(data));

            response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

            if (response.IsSuccessStatusCode)
            {
                using (var stream = response.Content.ReadAsStringAsync())
                {
                    if (stream.IsCompletedSuccessfully)
                    {
                        Token token = JsonConvert.DeserializeObject<Token>(stream.Result);
                        return token;
                    }
                }
            }

            return new();
        }
    }
}
