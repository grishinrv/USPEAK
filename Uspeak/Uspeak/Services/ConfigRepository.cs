using Microsoft.EntityFrameworkCore;
using NLog;
using System.Threading.Tasks;
using Uspeak.Persistence;

namespace Uspeak.Services
{
    public class ConfigRepository : IConfigRepository
    {
        private readonly IContextFactory _factory;
        private readonly ILogger _logger;
        public ConfigRepository(IContextFactory factory, ILogger logger)
        {
            _factory = factory;
            _logger = logger;
        }

        public async Task<string> GetValueAsync(string key)
        {
            using (var context = _factory.Create())
            {
                var val = await context.Config.FirstOrDefaultAsync(x => x.Key == key);
                return val?.Value ?? string.Empty;
            }
        }
    }
}
