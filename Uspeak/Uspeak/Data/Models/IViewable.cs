using System;

namespace Uspeak.Data.Models
{
    /// <summary>
    /// Сущность, доступная для показа в UI со стандартным набором свойств.
    /// </summary>
    public interface IViewable : INamed, IPersistable
    {
       string Description { get; set; }
    }
}
