namespace like_disc.Service.Connections
{
    public class Connection
    {
        public HttpClient Client()
        {
            HttpClient client = new();
            client.BaseAddress = new("https://api.spotify.com/v1/");
            return client;
        }
    }
}