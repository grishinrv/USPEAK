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

        public Task<List<Tag>> GetTags(TagType tagType, EntityType entityType) =>
            _tagRepository.GetTags(tagType, entityType);
    }
}
