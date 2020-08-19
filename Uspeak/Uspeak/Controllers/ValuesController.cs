using Microsoft.AspNetCore.Mvc;

namespace Uspeak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public int Get()
        {
            return 23;
        }
    }
}
