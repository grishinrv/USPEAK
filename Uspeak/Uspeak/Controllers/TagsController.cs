using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uspeak.Data.Models;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    [Route("api/[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ITagRepository _tagRepository;
        //private readonly ILogger _logger;

        public TagsController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
            // _logger = logger;
        }

        /// <summary>
        /// Получить список предметов, имеющих активные опубликованные курсы.
        /// </summary>
        [Route("Subjects")]
        [HttpGet]
        public async Task<IEnumerable<Tag>> GetSubjects() 
        {
            //_logger.Trace("Запрос получения списков предметов");
            var result = await _tagRepository.GetTags(TagType.StudySubject, EntityType.Course, EntityStatus.Published);
            return result;
        }
    }
}
