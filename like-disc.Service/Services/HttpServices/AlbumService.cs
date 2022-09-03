using like_disc.Core.Models;
using like_disc.Core.Services;

namespace like_disc.Service.Services.HttpServices
{
    public class AlbumService : SpotifyService<Album>, IAlbumService
    {
        public AlbumService(HttpClient client) : base(client)
        {
        }
    }
}
