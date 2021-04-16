using System;

namespace Uspeak.Data.Models
{
    /// <summary>
    /// Сущнность, сохраняемая в БД (имеющая уникальный идентификатор).
    /// </summary>
    public interface IPersistable
    {
        Guid Id { get; set; }
    }
}
