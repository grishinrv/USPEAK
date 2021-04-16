using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uspeak.Migrations
{
    public partial class asboutusconfigrucoursesevosubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Config",
                table: "Config");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Config");

            migrationBuilder.RenameTable(
                name: "Config",
                newName: "RuntimeConfiguration");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RuntimeConfiguration",
                table: "RuntimeConfiguration",
                column: "Key");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"),
                column: "CssClassesString",
                value: "evo children");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CssClassesString", "Description", "LessonDurationMinutes", "LessonsQuantity", "Name", "PromoImageId" },
                values: new object[,]
                {
                    { new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"), "ru children", @"Курс направлен на развитие знаний по русскому языку.
                                            Занятие ведет опытный педагог, который найдет ключик к любому малышу. 
                                            Занятия могут быть как индивидуальными, так и в мини-группе (до 3 человек).", null, null, "Курс для дошкольников", null },
                    { new Guid("509c15b7-438c-4927-b586-2747791b2a63"), "ru teenages", "Курс направлен на развитие знаний русского языка, а также на устранение пробелов знаний.", null, null, "Курс для детей младшей,  средней  и старшей школы", null },
                    { new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"), "ru exam", @"Курс направлен на развитие всех аспектов предмета. Особое внимание уделяется 
                                        рассмотрению специфики тестовых заданий , а также методики их выполнения. Также в ходе курса
                                        предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.", null, null, "Подготовка к ОГЭ и ЕГЭ", null }
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "CreatedTime", "Description", "EnityKind", "Name", "Status", "StatusChangedTime" },
                values: new object[,]
                {
                    { new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс направлен на развитие знаний по русскому языку.
                                        Занятие ведет опытный педагог, который найдет ключик к любому малышу. 
                                        Занятия могут быть как индивидуальными, так и в мини-группе (до 3 человек).", 2, "Курс для дошкольников", 1, new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("509c15b7-438c-4927-b586-2747791b2a63"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "Курс направлен на развитие знаний русского языка, а также на устранение пробелов знаний.", 2, "Курс для детей младшей,  средней  и старшей школы", 1, new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс направлен на развитие всех аспектов предмета. Особое внимание уделяется 
                                        рассмотрению специфики тестовых заданий , а также методики их выполнения. Также в ходе курса
                                        предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.", 2, "Подготовка к ОГЭ и ЕГЭ", 1, new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RuntimeConfiguration",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "about_us_full_text", @"Привет! Мы рады видеть Вас! Наша студия – это небольшое, но очень уютное пространство, 
                где найдется место каждому! Мы делаем все, чтобы приходя к нам за знаниями, 
                Вы получали их на высоком уровне, при этом также росли культурно и находили новых друзей. 
                Знания – это ключ к понимаю мира, который может подарить Вам множество возможностей. Добро пожаловать!" },
                    { "about_us_short_text", "Знания – ключ к пониманию мира, дарящий нам множество возможностей." }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CssClass", "Name", "TagKind" },
                values: new object[,]
                {
                    { new Guid("900c8402-e705-489d-a651-3336e37086b2"), "evo", "Развивайка", 0 },
                    { new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd"), "ru", "Русский язык", 0 }
                });

            migrationBuilder.InsertData(
                table: "EntitiesTags",
                columns: new[] { "EntityId", "TagId" },
                values: new object[,]
                {
                    { new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"), new Guid("900c8402-e705-489d-a651-3336e37086b2") },
                    { new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"), new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd") },
                    { new Guid("509c15b7-438c-4927-b586-2747791b2a63"), new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd") },
                    { new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"), new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RuntimeConfiguration",
                table: "RuntimeConfiguration");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("509c15b7-438c-4927-b586-2747791b2a63"));

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"));

            migrationBuilder.DeleteData(
                table: "EntitiesTags",
                keyColumns: new[] { "EntityId", "TagId" },
                keyValues: new object[] { new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"), new Guid("900c8402-e705-489d-a651-3336e37086b2") });

            migrationBuilder.DeleteData(
                table: "EntitiesTags",
                keyColumns: new[] { "EntityId", "TagId" },
                keyValues: new object[] { new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"), new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd") });

            migrationBuilder.DeleteData(
                table: "EntitiesTags",
                keyColumns: new[] { "EntityId", "TagId" },
                keyValues: new object[] { new Guid("509c15b7-438c-4927-b586-2747791b2a63"), new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd") });

            migrationBuilder.DeleteData(
                table: "EntitiesTags",
                keyColumns: new[] { "EntityId", "TagId" },
                keyValues: new object[] { new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"), new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd") });

            migrationBuilder.DeleteData(
                table: "RuntimeConfiguration",
                keyColumn: "Key",
                keyValue: "about_us_full_text");

            migrationBuilder.DeleteData(
                table: "RuntimeConfiguration",
                keyColumn: "Key",
                keyValue: "about_us_short_text");

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("509c15b7-438c-4927-b586-2747791b2a63"));

            migrationBuilder.DeleteData(
                table: "Entities",
                keyColumn: "Id",
                keyValue: new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("900c8402-e705-489d-a651-3336e37086b2"));

            migrationBuilder.RenameTable(
                name: "RuntimeConfiguration",
                newName: "Config");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Config",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Config",
                table: "Config",
                column: "Key");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"),
                column: "CssClassesString",
                value: "children");
        }
    }
}
