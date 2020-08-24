using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Uspeak.Data.Models;

namespace Uspeak.Services
{
    public interface ITagRepository
    {
        /// <summary>
        /// Получить список тэгов по типу тэга, типу сущностей и статусу сущностей.
        /// </summary>
        /// <param name="tagTypetype">тип тэга</param>
        /// <param name="entityType">тип сущности</param>
        /// <param name="status">статус сущности</param>
        /// <returns>Список тэгов по типу и статусу сущности.</returns>
        Task<List<Tag>> GetTags(TagType tagType, EntityType entityType, EntityStatus status);
        /// <summary>
        /// Получить набор тэгов сущности.
        /// </summary>
        /// <param name="entityId">id сущности</param>
        /// <returns>Список тэгов сущности.</returns>
        Task<List<Tag>> GetTags(Guid entityId);
    }
}