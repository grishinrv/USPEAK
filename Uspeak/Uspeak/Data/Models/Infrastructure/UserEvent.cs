using System.ComponentModel;

namespace Uspeak.Data.Models.Infrastructure
{
    public enum UserEvent
    {
        [Description("зашел на сайт")]
        System_LoggedIn = 0,
        [Description("вышел из сайта")]
        System_LoggedOut = 1,
        [Description("попытался зайти на сайт")]
        System_LogInTry = 2,

        [Description("создал пользователя")]
        Account_CreatedUser = 100,
        [Description("сменил пароль")]
        Account_ChangedPassword = 101,
        [Description("сменил настройки пользователя")]
        Account_Changed= 102,
        [Description("удалил пользователя")]
        Account_Deleted = 103,

        [Description("открыл")]
        Entity_HasOpened = 200,
        [Description("закрыл")]
        Entity_HasClosed = 201,
        [Description("создал")]
        Entity_Created = 202,
        [Description("изменил")]
        Entity_Changed = 203,
        [Description("удалил")]
        Entity_Deleted = 203,

    }
}
