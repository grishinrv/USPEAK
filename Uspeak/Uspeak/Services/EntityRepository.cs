using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uspeak.Data.Models;
using Uspeak.Persistence;
using Uspeak.Services.Exceptions;

namespace Uspeak.Services
{
    public class EntityRepository : IEntityRepository
    {
        private readonly IContextFactory _contextFactory;
        public EntityRepository(IContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<Entity>> GetEntities(EntityStatus status)
        {
            using (var context = _contextFactory.Create())
            {
                return await context.Entities.Where(x => x.Status == status).ToListAsync();
            }
        }

        public async Task<List<Entity>> GetEntities(EntityStatus status, EntityType type)
        {
            using (var context = _contextFactory.Create())
            {
                return await context.Entities.Where(x =>
                    x.Status == status
                    && x.EnityKind == type).ToListAsync();
            }
        }

        public async Task<List<Entity>> GetEntities(EntityType type)
        {
            using (var context = _contextFactory.Create())
            {
                return await context.Entities.Where(x => x.EnityKind == type).ToListAsync();
            }
        }

        public async Task<List<Entity>> GetEnities(EntityStatus status, DateTime statusSetEarlierThen,
            DateTime? statusSetLaterThen)
        {
            if (statusSetLaterThen != null && statusSetLaterThen > statusSetEarlierThen )
                throw new WrongTimePeriodsException($"{nameof(statusSetLaterThen)} ({statusSetLaterThen}) больше, чем " +
                                                    $"{nameof(statusSetEarlierThen)} ({statusSetEarlierThen}) -> периоды времени не пересекаются.");
            
            using (var context = _contextFactory.Create())
            {
                IQueryable<Entity> query = context.Entities.Where(x => x.Status == status
                                            && x.StatusChangedTime <= statusSetEarlierThen);
                if (statusSetLaterThen != null)
                    query = query.Where(x => x.StatusChangedTime >= statusSetLaterThen);
                return await query.ToListAsync();
            }
        }
    }
}