﻿using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Threading.Tasks;
using Uspeak.Data.Models;
using Uspeak.Services;

namespace Uspeak.Controllers
{
    public class TagsController : ControllerBase
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
        public async Task<IActionResult> GetSubjects() 
        {
            _logger.Trace("Запрос получения списков предметов");
            var result = await _tagRepository.GetTags(TagType.StudySubject, EntityType.Course, EntityStatus.Published);
            return Ok(result);
        }
    }
}
