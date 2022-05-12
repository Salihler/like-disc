using System.Net.Http.Headers;

namespace like_disc.Service.Connections
{
    public class Connection
    {
        public HttpClient Client()
        {
            HttpClient client = new();
            client.BaseAddress = new("https://api.spotify.com/v1/");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "BQDK3-IwQY-lv-oqkxjmzjDQBxGMitIatzHOy23aflTDMS_qLlnsVwPUH9It-nUGdqvVYpWRKmVlMffGZaUi_8H3xmFn6suDpJ-EFkepupdEm7x5m11uJt8Qv76mCDG9nyJkmjebvKjUEFaPbxIt");
            return client;
        }
    }
}