using Microsoft.EntityFrameworkCore;

namespace Uspeak.Persistence
{
    public class ContextFactory : IContextFactory
    {
        private readonly DbContextOptionsBuilder _optionsBuilder;

        public ContextFactory(string connectionString)
        { 
            _optionsBuilder = new DbContextOptionsBuilder<UspeakDbContext>();
            _optionsBuilder.UseSqlServer(connectionString);
        }

        public IUspeakDbContext Create() => new UspeakDbContext(_optionsBuilder.Options);
    }
}
