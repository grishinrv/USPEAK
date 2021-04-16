using System.ComponentModel;

namespace Uspeak.Data.Models
{
    public enum EntityStatus
    {
        [Description("Черновик")]
        Draft = 0,
        [Description("Опубликовано")]
        Published = 1,
        [Description("Удалено в корзину")]
        Basket = 2
    }
}