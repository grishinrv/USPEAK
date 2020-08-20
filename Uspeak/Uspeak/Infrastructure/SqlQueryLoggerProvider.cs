using Microsoft.Extensions.Logging;

namespace Uspeak.Infrastructure
{
    public class SqlQueryLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new Logger(null);//todo
        }

        public void Dispose()
        {
        }
    }
}
