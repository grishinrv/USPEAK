using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NLog;

namespace Uspeak.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ErrorController : Controller
    {
        private readonly ILogger _logger;

        public ErrorController(ILogger logger)
        {
            _logger = logger;
        }

        public void Index()
        {
            // Retrieve error information in case of internal errors
            var error = HttpContext
                      .Features
                      .Get<IExceptionHandlerFeature>();
            if (error != null)
            {
                // Use the information about the exception 
                var exception = error.Error;
                _logger.Trace($"{exception.Message} {exception.StackTrace}");
            }
        }
    }
}
