using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uspeak.Data.Models;
using Uspeak.Persistence;

namespace Uspeak.Services
{
    public class TagRepository : ITagRepository
    {
        private readonly IContextFactory _contextFactory;

        public TagRepository(IContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }
        
        public Task<List<Tag>> GetTags(TagType tagType, EntityType entityType)
        {
            using (var context = _contextFactory.Create())
            {
                return context.Entities
                    .Where(x=> x.EnityKind == entityType)
                    .SelectMany<Entity, Tag>(t => t.EntityTags.Select(e => e.Tag).Where(a =>a.TagKind == tagType))
                    .Distinct()
                    .ToListAsync();
            }
        }
    }
}