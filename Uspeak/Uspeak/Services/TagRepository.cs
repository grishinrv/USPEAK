using System;
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

        public async Task<List<Tag>> GetTags(TagType tagType, EntityType entityType, EntityStatus status)
        {
            using (var context = _contextFactory.Create())
            {
                return await context.Entities
                    .Where(x=> x.EnityKind == entityType && x.Status == status)
                    .SelectMany<Entity, Tag>(t => t.EntityTags.Select(e => e.Tag).Where(a =>a.TagKind == tagType))
                    .Distinct()
                    .ToListAsync();
            }
        }

        public async Task<List<Tag>> GetTags(Guid entityId)
        {
            using (var context = _contextFactory.Create())
            {
                var tagEntities = await context.EntitiesTags.Where(x => x.EntityId == entityId)
                            .Include(et => et.Tag)
                            .ToListAsync();
                return tagEntities.Select(x => x.Tag).ToList();
            }
        }
    }
}