using System.ComponentModel;

namespace Uspeak.Data.Models
{
    /// <summary>
    /// Типы тэгов.
    /// </summary>
    public enum TagType
    {
        [Description("Предмет")]
        StudySubject = 0,
        [Description("Целевая аудитория")]
        TargetAaudience = 1,
        [Description("Формат")]
        Format = 2,
        [Description("Требуемый уровень предварительной подготовки")]
        PreCondition = 3,
        [Description("Длительность")]
        Duration = 4,
        [Description("Скидки")]
        Discount = 5,
        [Description("Сложность")]
        Сomplexity = 6
    }
}
