using System.Net.Http.Headers;
using like_disc.Core.Models;
using like_disc.Service.Connections;

namespace like_disc.Service
{
    public class Context<Tentity> where Tentity : class
    {
        private HttpClient _client;

        public Context(Connection connection)
        {
            _client = connection.Client();
        }

        public async Task<Tentity> Get()
        {
            var response =  await _client.GetAsync("albums/4aawyAB9vmqN3uQ7FjRGTy");
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "BQDK3-IwQY-lv-oqkxjmzjDQBxGMitIatzHOy23aflTDMS_qLlnsVwPUH9It-nUGdqvVYpWRKmVlMffGZaUi_8H3xmFn6suDpJ-EFkepupdEm7x5m11uJt8Qv76mCDG9nyJkmjebvKjUEFaPbxIt");
        }

    }
}