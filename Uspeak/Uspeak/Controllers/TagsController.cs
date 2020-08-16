using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Linq;
using System.Threading.Tasks;
using Uspeak.Data.Models;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    public class TagsController : Controller
    {
        private readonly ITagRepository _tagRepository;
        private readonly ILogger _logger;

        public TagsController(ITagRepository tagRepository, ILogger logger)
        {
            _tagRepository = tagRepository;
            _logger = logger;
        }

        /// <summary>
        /// Получить список предметов, имеющих активные опубликованные курсы.
        /// </summary>
        /// <returns>List<Tag></Tag></returns>
        [HttpGet]
        public async Task<JsonResult> GetSubjects() 
        {
            //_logger.Trace("Запрос получения списков предметов");
            var result = await _tagRepository.GetTags(TagType.StudySubject, EntityType.Course, EntityStatus.Published);
            var jsonResult = Json(result.FirstOrDefault());
            return jsonResult;
        }
    }
}
