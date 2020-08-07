using System.Collections.Generic;
using System.Threading.Tasks;
using Uspeak.Data.Models;

namespace Uspeak.Services
{
    public interface ITagRepository
    {
        /// <summary>
        /// Получить список тэгов по типу тэга, и по статусу сущностей.
        /// </summary>
        /// <param name="tagTypetype">тип тэга</param>
        /// <param name="entityType">статус сущности</param>
        /// <returns>Список действующих тэгов по типу.</returns>
        Task<List<Tag>> GetTags(TagType tagType, EntityType entityType);
    }
}