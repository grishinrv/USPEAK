using Microsoft.Extensions.Logging;

namespace Uspeak.Infrastructure
{
    public class SqlQueryLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new Logger();//todo
        }

        public void Dispose()
        {
        }
    }
}
