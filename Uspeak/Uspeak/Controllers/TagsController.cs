using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uspeak.Data.Models;
using Uspeak.Infrastructure.Mapping;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    [Route("api/Tags")]
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
        /// GET: api/Tags/Subjects
        /// </summary>
        [HttpGet("Subjects")]
        public async Task<IEnumerable<Tag>> GetSubjects() 
        {
            //_logger.Trace("Запрос получения списков предметов");
            var result = await _tagRepository.GetTags(TagType.StudySubject, EntityType.Course, EntityStatus.Published);
            return result;
        }

        /// <summary>
        /// Получить список тэгов по id сущности.
        /// GET: api/Tags/Subjects/id
        /// </summary>
        [HttpGet("ByEntity/{id}")]
        public async Task<IEnumerable<Data.Dto.Tag>> GetByEntity(Guid id)
        {
            //_logger.Trace("Запрос получения списка тэгов по сущности");
            try
            {
                var tags = await _tagRepository.GetTags(id);
                var result = tags.Select(x => x.Map<Tag, Data.Dto.Tag>())
                    .OrderBy(x => x.Name).ToList();
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
