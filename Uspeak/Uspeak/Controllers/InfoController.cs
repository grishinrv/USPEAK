using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    [Route("api/Info")]
    public class InfoController : ControllerBase
    {
        private readonly IConfigRepository _configRepository;

        public InfoController(IConfigRepository configRepository)
        {
            _configRepository = configRepository;
        }

        [HttpGet("AboutUsFullText")]
        public async Task<string> AboutUsFullText()
        {
            return await _configRepository.GetValueAsync("about_us_full_text");
        }

        [HttpGet("AboutUsShortText")]
        public async Task<string> AboutUsShortText()
        {
            return await _configRepository.GetValueAsync("about_us_short_text");
        }
    }
}
