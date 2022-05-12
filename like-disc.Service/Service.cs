using like_disc.Service.Connections;

namespace like_disc.Service
{
    public class Service<TEntity> where TEntity : class
    {
        private readonly Context<TEntity> _context;
        public Service()
        {
            _context = new(new Connection());
        }
    }
}