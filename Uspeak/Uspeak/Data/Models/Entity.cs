﻿using System;
using System.Collections.Generic;

namespace Uspeak.Data.Models
{
    public class Entity : IPersistable, IViewable
    {
        public Guid Id { get; set; }
        public EntityType EnityKind { get; set; }
        /// <summary>
        /// Описание. Дублирует поле основной сущности, для обеспечения полнотекстового поиска и уменьшения кол-ва соединений.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Наименование. Дублирует поле основной сущности, для обеспечения полнотекстового поиска и уменьшения кол-ва соединений.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Список подвешеных тэгов.
        /// </summary>
        public virtual ICollection<EntityTag> EntityTags { get; set; }
        /// <summary>
        /// Время создания сущности в системе.
        /// </summary>
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// Статус ЖЦ сущности
        /// </summary>
        public EntityStatus Status { get; set; }
        /// <summary>
        /// Время установки текущего статуса ЖЦ.
        /// </summary>
        public DateTime StatusChangedTime { get; set; }
    }
}
