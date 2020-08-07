using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uspeak.Data.Models;

namespace Uspeak.Services
{
    public interface IEntityRepository
    {
        Task<List<Entity>> GetEntities(EntityStatus status);
        Task<List<Entity>> GetEntities(EntityStatus status, EntityType type);
        Task<List<Entity>> GetEntities(EntityType type);

        Task<List<Entity>> GetEnities(EntityStatus status, DateTime statusSetEarlierThen,
            DateTime? statusSetLaterThen);
    }
}