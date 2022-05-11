using like_disc.Core.Models;

namespace like_disc.Service
{
    public class Context<Tentity> where Tentity : class
    {
        private HttpClient _client;

        public Context(HttpClient client)
        {
            _client = client;
        }

        public async Task<Tentity> Get()
        {
            var album = new Album();
            album.Id = "sadas";
            return (Tentity)Convert.ChangeType(album, typeof(Tentity));
        }

    }
}