using like_disc.Core.Models;
using like_disc.Service.Connections;

namespace like_disc.Service
{
    public class AlbumService : Service<Album>
    {
        public readonly Connection _connection;
        public AlbumService()
        {
            _connection = new();
        }
    }
}