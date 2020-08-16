using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Threading.Tasks;
using Uspeak.Data.Models.Tests;

namespace Uspeak.Controllers
{
    public class QuestionSettingsController : Controller
    {
        private readonly ILogger _logger;

        public QuestionSettingsController(ILogger logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<QuestionSettings> CreateQuestion(QuestionSettings draft)
        {
            await Task.Delay(200);
            return draft;
        }

        [HttpGet]
        public JsonResult CreateQuestion()
        {
            //_logger.Trace("Запрос создания шаблона вопроса");
            var result =  new QuestionSettings() 
            { 
                Name = "How many help-verbs are there in English language?",
                Description="Choose one right answer"
            };
            return Json(result);
        }
    }
}
