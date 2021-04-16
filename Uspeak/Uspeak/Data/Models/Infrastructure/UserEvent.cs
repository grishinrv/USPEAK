using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
        [Description("изменил настройки системы")]
        System_SettingChanged = 3,

        [Description("создал пользователя")]
        Account_CreatedUser = 100,
        [Description("сменил пароль")]
        Account_ChangedPassword = 101,
        [Description("сменил настройки пользователя")]
        Account_Changed= 102,
        [Description("удалил пользователя")]
        Account_Deleted = 103,
        [Description("сменил роль пользователя")]
        Account_RoleChanged = 104,

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

        [Description("начал занятие")]
        Lesson_Started = 301,
        [Description("окончил занятие")]
        Lesson_Finised = 302,
        [Description("установил домашнее задание к занятию")]
        Lesson_HomeTaskSet = 303,
        [Description("изменил домашнее задание к занятию")]
        Lesson_HomeTaskChanged = 304,
        [Description("запланировал занятие")]
        Lesson_Planned = 305,
        [Description("изменил время занятия")]
        Lesson_DateTimeChanged = 306,
        [Description("отменил занятие")]
        Lesson_Cancelled = 307,

        [Description("добавил студента в группу")]
        Group_AddedStudent = 401,
        [Description("удалил студента из группы")]
        Group_RemovedStudent = 402,
        [Description("изменил данные группы")]
        Group_Changed = 403,

        [Description("отметил присутствие на занятии")]
        Presence_SetStudentState = 502,
        [Description("изменил присутствие на занятии")]
        Presence_ChangedStudentState = 503,
        [Description("установил комментарий к присутствию на занятии")]
        Presence_SetComment = 504


    }
}
