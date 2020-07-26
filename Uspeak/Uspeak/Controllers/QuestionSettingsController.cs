using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Uspeak.Data.Models.Tests;

namespace Uspeak.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionSettingsController : ControllerBase
    {
        [HttpPost]
        public async Task<QuestionSettings> CreateQuestion(QuestionSettings draft)
        {
            await Task.Delay(200);
            return draft;
        }

        [HttpGet]
        public QuestionSettings CreateQuestion()
        {
            return new QuestionSettings() 
            { 
                Name = "How many help-verbs are there in English language?",
                Description="Choose one right answer"
            };
        }
    }
}
