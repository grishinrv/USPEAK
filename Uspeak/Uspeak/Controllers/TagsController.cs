using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uspeak.Data.Models;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ITagRepository _tagRepository;

        public TagsController(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        /// <summary>
        /// Получить список предметов, имеющих активные опубликованные курсы.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Task<List<Tag>> GetSubjects() =>
            _tagRepository.GetTags(TagType.StudySubject, EntityType.Course, EntityStatus.Published);
    }
}
