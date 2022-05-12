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
    }
}