namespace like_disc.Service
{
    public class Service<TEntity> where TEntity : class
    {
        private readonly Context<TEntity> _context;
        private readonly HttpClient _client;

        public Service()
        {
            _client = new HttpClient();
            _context = new Context<TEntity>(_client);
        }

        public async Task<TEntity> Get()
        {
            var result = await _context.Get();
            return result;
        }
    }
}