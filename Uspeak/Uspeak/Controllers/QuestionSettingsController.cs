using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Threading.Tasks;
using Uspeak.Data.Models.Tests;

namespace Uspeak.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuestionSettingsController : ControllerBase
    {
        private readonly ILogger _logger;

        public QuestionSettingsController(ILogger logger)
        {
            _logger = logger;
        }

        public async Task<QuestionSettings> CreateQuestion(QuestionSettings draft)
        {
            await Task.Delay(200);
            return draft;
        }

        [HttpGet("Create")]
        public QuestionSettings CreateQuestion()
        {
            //_logger.Trace("Запрос создания шаблона вопроса");
            var result =  new QuestionSettings() 
            { 
                Name = "How many help-verbs are there in English language?",
                Description="Choose one right answer"
            };
            return result;
        }
    }
}
