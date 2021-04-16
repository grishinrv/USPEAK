using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Uspeak.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Config",
                columns: table => new
                {
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Config", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EnityKind = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    DisplayedName = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TagKind = table.Column<int>(nullable: false),
                    CssClass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PromoImageId = table.Column<Guid>(nullable: true),
                    CssClassesString = table.Column<string>(nullable: true),
                    LessonsQuantity = table.Column<int>(nullable: true),
                    LessonDurationMinutes = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Images_PromoImageId",
                        column: x => x.PromoImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RegisteredTime = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastTimePasswordChanged = table.Column<DateTime>(nullable: false),
                    TypeOfUser = table.Column<int>(nullable: false),
                    UserFolder = table.Column<string>(nullable: true),
                    PortraitId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Images_PortraitId",
                        column: x => x.PortraitId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntitiesTags",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(nullable: false),
                    TagId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntitiesTags", x => new { x.EntityId, x.TagId });
                    table.ForeignKey(
                        name: "FK_EntitiesTags_Entities_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntitiesTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RandomizeQuestionOrder = table.Column<bool>(nullable: false),
                    ShowRightChosesAmount = table.Column<bool>(nullable: false),
                    CourseForeignKey = table.Column<Guid>(nullable: false),
                    CourseId = table.Column<Guid>(nullable: true),
                    AuthorForeignKey = table.Column<Guid>(nullable: false),
                    AuthorId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestSettings_User_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestSettings_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TestForeignKey = table.Column<Guid>(nullable: false),
                    TestId = table.Column<Guid>(nullable: true),
                    QuestionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionSettings_TestSettings_TestId",
                        column: x => x.TestId,
                        principalTable: "TestSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnswerOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    RightAnswer = table.Column<string>(nullable: true),
                    WinPoints = table.Column<decimal>(nullable: false),
                    LoosePoints = table.Column<decimal>(nullable: false),
                    QuestionForeignKey = table.Column<Guid>(nullable: false),
                    QuestionId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnswerOption_QuestionSettings_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "QuestionSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CssClassesString", "Description", "LessonDurationMinutes", "LessonsQuantity", "Name", "PromoImageId" },
                values: new object[,]
                {
                    { new Guid("30bc01bf-8cbe-4252-a5f6-4017f601c8c3"), "eng children", @"Курс поможет Вашему ребенку подготовиться к школе не только по основным предметам, 
                                        но и включает в себя занятия английским. В ходе занятий ребенок в игровой форме познакомиться 
                                        с русским и английским  алфавитами, научится читать на русском и английском, научится считать. 
                                        Курс поможет развитию логики, любознательности и не отпугнет желание ребенка учиться. 
                                        Занятия проходят в мини-группах (до 4 человек ), что обеспечивает индивидуальный подход к каждому малышу.", null, null, "Подготовка к школе с английским языком", null },
                    { new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"), "children", @"«Кубики Зайцева» — пособие для обучения чтению с двух лет. 
                                        Эта методика обучения чтению прошла испытание временем, ведь уже более 20 лет она пользуется 
                                        огромной популярностью как среди родителей, так и педагогов дошкольных учреждений. 
                                        Обучение с помощью кубиков  обеспечивает наглядность и системность подачи материала. 
                                        Занятия проходят в игровой форме.", null, null, "Обучение чтению на основе кубиков Зайцева", null },
                    { new Guid("89268a4f-1774-401f-8083-d2b316c20975"), "physics exam", @"Курс направлен на развитие всех аспектов языка. 
                                        Особое внимание уделяется рассмотрению специфики тестовых заданий, 
                                        а также методики их выполнения. Также в ходе курса предусмотрены пробные тестирования 
                                        с тренировкой заполнения бланков.", null, null, "Подготовка к ОГЭ и ЕГЭ", null },
                    { new Guid("38e207fc-de41-47fa-bb9b-912e83328896"), "physics teenagers", "Курс направлен на развитие и углубление знаний, а также на устранение пробелов знаний.", null, null, "Курс для детей средней и старшей школы", null },
                    { new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"), "math exam", @"Курс направлен на развитие всех аспектов предмета. 
                                        Особое внимание уделяется рассмотрению специфики тестовых заданий, а также методики их выполнения. 
                                        Также в ходе курса предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.", null, null, "Подготовка к ОГЭ и ЕГЭ", null },
                    { new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"), "math teenagers", "Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.", null, null, "Курс для детей младшей, средней и старшей школы", null },
                    { new Guid("b18c7332-bbbd-44bf-987e-313f43fd55e0"), "math children", @"Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.
                                        Занятие ведет опытный педагог, который найдет ключик к любому малышу. 
                                        Занятия могут быть как индивидуальными, так и в мини-группе (до 3 человек)", null, null, "Курс для дошкольников", null },
                    { new Guid("59cbe049-bc81-4f19-9264-707ac2734d77"), "ch teenagers", @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс по китайскому для детей и подростков ( от 5 лет)", null },
                    { new Guid("0ff2e69b-05fa-4e3c-8f16-b85e699baee3"), "it", @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.", null, null, "Разговорный итальянский", null },
                    { new Guid("872e64dd-fcd5-4650-b454-17d82f43a2a7"), "it adults", @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс итальянского для взрослых", null },
                    { new Guid("8b4739e7-61d1-4213-8e61-433c91a87a1e"), "it teenagers", @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс по итальянскому для детей и подростков ( от 5 лет)", null },
                    { new Guid("df87b337-60b6-4011-b781-3cd2d8dce904"), "fr", @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.", null, null, "Разговорный французский", null },
                    { new Guid("32a53c0f-87ff-403d-b3f2-7aa978c37531"), "ch adults", @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс китайского для взрослых", null },
                    { new Guid("59baec0a-54f7-4b35-bb09-53df0468f198"), "fr teenagers", @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс по французскому для детей и подростков ( от 5 лет)", null },
                    { new Guid("c182e464-9ccb-4e26-812f-4c90d178f57f"), "de", @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.", null, null, "Разговорный немецкий", null },
                    { new Guid("91cfb955-12a6-464a-b8f1-87b40c25fce7"), "de adults", @"Общий курс подразумевает изучение основных аспектов языка: 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс немецкого для взрослых", null },
                    { new Guid("5da65f09-8783-4eae-9d77-658c63b11116"), "de teenagers", @"Общий курс подразумевает изучение основных аспектов языка: 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс по немецкому для детей и подростков (от 5 лет)", null },
                    { new Guid("b975c806-db88-414c-9e00-9d245ac7acc9"), "eng", @"За чашкой чая поболтаем на английском с носителем языка. 
                                        Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер.
                                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.", null, null, "Английский разговорный клуб “Tea and talk”", null },
                    { new Guid("a032649c-5f7d-4a64-b13b-468f46764e98"), "eng", @"Отличный способ отдохнуть с пользой. Кинозал открыт как для детей, так и для взрослых. 
                                        Мы смотрим фильмы в оригинале. Перед просмотром каждый получает рабочую тетрадь, 
                                        в которой подготовлены и разобраны лексические (слова) и грамматические аспекты, 
                                        встречаемые в фильме. Все это поможет комфортно и понятно 😊 посмотреть фильм. 
                                        После кино-сеанса мы, конечно, обсудим фильм и все, возможно, появившиеся вопросы.", null, null, "Кинозал на английском", null },
                    { new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"), "eng adults", "Если вы хотите общаться без помощи гида в отеле, аэропорту, гостинице или в городе, тогда этот курс для Вас.", null, null, "Туристический английский", null },
                    { new Guid("59ac3930-3825-4cb2-9fe7-4ff499947176"), "eng exam", @"Курс направлен на развитие всех аспектов языка. 
                                        Особое внимание уделяется рассмотрению специфики тестовых заданий, 
                                        а также методики их выполнения. Также в ходе курса предусмотрены пробные тестирования 
                                        с тренировкой заполнения бланков.", null, null, "Подготовка к ОГЭ и ЕГЭ", null },
                    { new Guid("0bd380cf-78af-4338-a508-bc41afe6c1af"), "eng adults", @"Общий курс подразумевает изучение основных аспектов языка: 
                                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс английского для взрослых", null },
                    { new Guid("73ccf858-3467-4a6b-a8ac-ee7cfc85f620"), "eng teenagers", @"Общий курс подразумевает изучение основных аспектов языка: 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс по английскому для детей и подростков ( от 5 лет)", null },
                    { new Guid("6e77f097-c273-42f6-bb1e-bf0d25b1bbe7"), "fr adults", @"Общий курс подразумевает изучение основных аспектов языка: 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", null, null, "Общий курс французского для взрослых", null }
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Id", "CreatedTime", "Description", "EnityKind", "Name" },
                values: new object[,]
                {
                    { new Guid("872e64dd-fcd5-4650-b454-17d82f43a2a7"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс итальянского для взрослых" },
                    { new Guid("0ff2e69b-05fa-4e3c-8f16-b85e699baee3"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.", 2, "Разговорный итальянский" },
                    { new Guid("59cbe049-bc81-4f19-9264-707ac2734d77"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс по китайскому для детей и подростков ( от 5 лет)" },
                    { new Guid("32a53c0f-87ff-403d-b3f2-7aa978c37531"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс китайского для взрослых" },
                    { new Guid("b18c7332-bbbd-44bf-987e-313f43fd55e0"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.
                                        Занятие ведет опытный педагог, который найдет ключик к любому малышу. 
                                        Занятия могут быть как индивидуальными, так и в мини-группе (до 3 человек)", 2, "Курс для дошкольников" },
                    { new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"«Кубики Зайцева» — пособие для обучения чтению с двух лет. 
                                        Эта методика обучения чтению прошла испытание временем, ведь уже более 20 лет она пользуется 
                                        огромной популярностью как среди родителей, так и педагогов дошкольных учреждений. 
                                        Обучение с помощью кубиков  обеспечивает наглядность  и системность подачи материала. 
                                        Занятия проходят в игровой форме.", 2, "Обучение чтению на основе кубиков Зайцева" },
                    { new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс направлен на развитие всех аспектов предмета. 
                                        Особое внимание уделяется рассмотрению специфики тестовых заданий, а также методики их выполнения. 
                                        Также в ходе курса предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.", 2, "Подготовка к ОГЭ и ЕГЭ" },
                    { new Guid("38e207fc-de41-47fa-bb9b-912e83328896"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "Курс направлен на развитие и углубление знаний, а также на устранение пробелов знаний.", 2, "Курс для детей средней и старшей школы" },
                    { new Guid("89268a4f-1774-401f-8083-d2b316c20975"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс направлен на развитие всех аспектов языка. 
                                        Особое внимание уделяется рассмотрению специфики тестовых заданий, 
                                        а также методики их выполнения. Также в ходе курса предусмотрены пробные тестирования 
                                        с тренировкой заполнения бланков.", 2, "Подготовка к ОГЭ и ЕГЭ" },
                    { new Guid("8b4739e7-61d1-4213-8e61-433c91a87a1e"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс по итальянскому для детей и подростков ( от 5 лет)" },
                    { new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.", 2, "Курс для детей младшей,  средней  и старшей школы" },
                    { new Guid("df87b337-60b6-4011-b781-3cd2d8dce904"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.", 2, "Разговорный французский" },
                    { new Guid("a032649c-5f7d-4a64-b13b-468f46764e98"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Отличный способ отдохнуть с пользой. Кинозал открыт как для детей, так и для взрослых. 
                                        Мы смотрим фильмы в оригинале. Перед просмотром каждый получает рабочую тетрадь, 
                                        в которой подготовлены и разобраны лексические (слова) и грамматические аспекты, 
                                        встречаемые в фильме. Все это поможет комфортно и понятно 😊 посмотреть фильм. 
                                        После кино-сеанса мы, конечно, обсудим фильм и все, возможно, появившиеся вопросы.", 2, "Кинозал на английском" },
                    { new Guid("59baec0a-54f7-4b35-bb09-53df0468f198"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс по французскому для детей и подростков ( от 5 лет)" },
                    { new Guid("6e77f097-c273-42f6-bb1e-bf0d25b1bbe7"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс французского для взрослых" },
                    { new Guid("73ccf858-3467-4a6b-a8ac-ee7cfc85f620"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс по английскому для детей и подростков ( от 5 лет)" },
                    { new Guid("0bd380cf-78af-4338-a508-bc41afe6c1af"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс английского для взрослых" },
                    { new Guid("59ac3930-3825-4cb2-9fe7-4ff499947176"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс направлен на развитие всех аспектов языка. 
                                        Особое внимание уделяется рассмотрению специфики тестовых заданий, 
                                        а также методики их выполнения. Также в ходе курса предусмотрены пробные тестирования 
                                        с тренировкой заполнения бланков.", 2, "Подготовка к ОГЭ и ЕГЭ" },
                    { new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "Если вы хотите общаться без помощи гида в отеле, аэропорту, гостинице или в городе, тогда этот курс для Вас.", 2, "Туристический английский" },
                    { new Guid("30bc01bf-8cbe-4252-a5f6-4017f601c8c3"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс поможет Вашему ребенку подготовиться к школе не только по основным предметам, 
                                        но и включает в себя занятия английским. В ходе занятий ребенок в игровой форме познакомиться 
                                        с русским и английским  алфавитами, научится читать на русском и английском, научится считать. 
                                        Курс поможет развитию логики, любознательности и не отпугнет желание ребенка учиться. 
                                        Занятия проходят в мини-группах (до 4 человек ), что обеспечивает индивидуальный подход к каждому малышу.", 2, "Подготовка к школе с английским языком" },
                    { new Guid("b975c806-db88-414c-9e00-9d245ac7acc9"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"За чашкой чая поболтаем на английском с носителем языка. 
                                        Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер.
                                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.", 2, "Английский разговорный клуб “Tea and talk”" },
                    { new Guid("5da65f09-8783-4eae-9d77-658c63b11116"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс по немецкому для детей и подростков (от 5 лет)" },
                    { new Guid("91cfb955-12a6-464a-b8f1-87b40c25fce7"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Общий курс подразумевает изучение основных аспектов языка : 
                                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.", 2, "Общий курс немецкого для взрослых" },
                    { new Guid("c182e464-9ccb-4e26-812f-4c90d178f57f"), new DateTime(2020, 8, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.", 2, "Разговорный немецкий" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CssClass", "Name", "TagKind" },
                values: new object[,]
                {
                    { new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5"), "adults", "для взрослых", 1 },
                    { new Guid("bf53a489-cdca-47c0-ac5c-3437c47c19c6"), "ch", "Китайский", 0 },
                    { new Guid("2b474a26-76d2-45ee-be3e-f38eca83d9ee"), "children", "для детей", 1 },
                    { new Guid("fff0e828-e9c8-4ae5-b33a-df1c1f23f874"), "de", "Немецкий", 0 },
                    { new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430"), "eng", "Английский", 0 },
                    { new Guid("1dceded6-3990-4cb3-bc2e-936d0ae7f79d"), "exam", "Подготовка к экзаменам", 7 },
                    { new Guid("c4e7b67e-809a-40d2-a222-0a12f35ba22f"), "fr", "Французский", 0 },
                    { new Guid("b66d4365-0bb7-4ea0-9c63-86166aec8aa3"), "it", "Итальянский", 0 },
                    { new Guid("866787e8-9e2e-48ae-aedd-0dcbafa5edcc"), "math", "Математика", 0 },
                    { new Guid("a6eecf1c-207a-4214-9897-bb2403aaf9d0"), "physics", "Физика", 0 },
                    { new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0"), "teenagers", "детей средней и старшей школы", 1 }
                });

            migrationBuilder.InsertData(
                table: "EntitiesTags",
                columns: new[] { "EntityId", "TagId" },
                values: new object[,]
                {
                    { new Guid("32a53c0f-87ff-403d-b3f2-7aa978c37531"), new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5") },
                    { new Guid("59ac3930-3825-4cb2-9fe7-4ff499947176"), new Guid("1dceded6-3990-4cb3-bc2e-936d0ae7f79d") },
                    { new Guid("59baec0a-54f7-4b35-bb09-53df0468f198"), new Guid("c4e7b67e-809a-40d2-a222-0a12f35ba22f") },
                    { new Guid("6e77f097-c273-42f6-bb1e-bf0d25b1bbe7"), new Guid("c4e7b67e-809a-40d2-a222-0a12f35ba22f") },
                    { new Guid("df87b337-60b6-4011-b781-3cd2d8dce904"), new Guid("c4e7b67e-809a-40d2-a222-0a12f35ba22f") },
                    { new Guid("8b4739e7-61d1-4213-8e61-433c91a87a1e"), new Guid("b66d4365-0bb7-4ea0-9c63-86166aec8aa3") },
                    { new Guid("872e64dd-fcd5-4650-b454-17d82f43a2a7"), new Guid("b66d4365-0bb7-4ea0-9c63-86166aec8aa3") },
                    { new Guid("0ff2e69b-05fa-4e3c-8f16-b85e699baee3"), new Guid("b66d4365-0bb7-4ea0-9c63-86166aec8aa3") },
                    { new Guid("b18c7332-bbbd-44bf-987e-313f43fd55e0"), new Guid("866787e8-9e2e-48ae-aedd-0dcbafa5edcc") },
                    { new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"), new Guid("866787e8-9e2e-48ae-aedd-0dcbafa5edcc") },
                    { new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"), new Guid("866787e8-9e2e-48ae-aedd-0dcbafa5edcc") },
                    { new Guid("38e207fc-de41-47fa-bb9b-912e83328896"), new Guid("a6eecf1c-207a-4214-9897-bb2403aaf9d0") },
                    { new Guid("89268a4f-1774-401f-8083-d2b316c20975"), new Guid("a6eecf1c-207a-4214-9897-bb2403aaf9d0") },
                    { new Guid("38e207fc-de41-47fa-bb9b-912e83328896"), new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0") },
                    { new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"), new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0") },
                    { new Guid("59cbe049-bc81-4f19-9264-707ac2734d77"), new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0") },
                    { new Guid("8b4739e7-61d1-4213-8e61-433c91a87a1e"), new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0") },
                    { new Guid("59baec0a-54f7-4b35-bb09-53df0468f198"), new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0") },
                    { new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"), new Guid("1dceded6-3990-4cb3-bc2e-936d0ae7f79d") },
                    { new Guid("89268a4f-1774-401f-8083-d2b316c20975"), new Guid("1dceded6-3990-4cb3-bc2e-936d0ae7f79d") },
                    { new Guid("a032649c-5f7d-4a64-b13b-468f46764e98"), new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430") },
                    { new Guid("b975c806-db88-414c-9e00-9d245ac7acc9"), new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430") },
                    { new Guid("872e64dd-fcd5-4650-b454-17d82f43a2a7"), new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5") },
                    { new Guid("6e77f097-c273-42f6-bb1e-bf0d25b1bbe7"), new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5") },
                    { new Guid("91cfb955-12a6-464a-b8f1-87b40c25fce7"), new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5") },
                    { new Guid("0bd380cf-78af-4338-a508-bc41afe6c1af"), new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5") },
                    { new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"), new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5") },
                    { new Guid("59cbe049-bc81-4f19-9264-707ac2734d77"), new Guid("bf53a489-cdca-47c0-ac5c-3437c47c19c6") },
                    { new Guid("32a53c0f-87ff-403d-b3f2-7aa978c37531"), new Guid("bf53a489-cdca-47c0-ac5c-3437c47c19c6") },
                    { new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"), new Guid("2b474a26-76d2-45ee-be3e-f38eca83d9ee") },
                    { new Guid("5da65f09-8783-4eae-9d77-658c63b11116"), new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0") },
                    { new Guid("b18c7332-bbbd-44bf-987e-313f43fd55e0"), new Guid("2b474a26-76d2-45ee-be3e-f38eca83d9ee") },
                    { new Guid("5da65f09-8783-4eae-9d77-658c63b11116"), new Guid("fff0e828-e9c8-4ae5-b33a-df1c1f23f874") },
                    { new Guid("91cfb955-12a6-464a-b8f1-87b40c25fce7"), new Guid("fff0e828-e9c8-4ae5-b33a-df1c1f23f874") },
                    { new Guid("c182e464-9ccb-4e26-812f-4c90d178f57f"), new Guid("fff0e828-e9c8-4ae5-b33a-df1c1f23f874") },
                    { new Guid("30bc01bf-8cbe-4252-a5f6-4017f601c8c3"), new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430") },
                    { new Guid("73ccf858-3467-4a6b-a8ac-ee7cfc85f620"), new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430") },
                    { new Guid("0bd380cf-78af-4338-a508-bc41afe6c1af"), new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430") },
                    { new Guid("59ac3930-3825-4cb2-9fe7-4ff499947176"), new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430") },
                    { new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"), new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430") },
                    { new Guid("30bc01bf-8cbe-4252-a5f6-4017f601c8c3"), new Guid("2b474a26-76d2-45ee-be3e-f38eca83d9ee") },
                    { new Guid("73ccf858-3467-4a6b-a8ac-ee7cfc85f620"), new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerOption_QuestionId",
                table: "AnswerOption",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_PromoImageId",
                table: "Courses",
                column: "PromoImageId");

            migrationBuilder.CreateIndex(
                name: "IX_EntitiesTags_TagId",
                table: "EntitiesTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionSettings_TestId",
                table: "QuestionSettings",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSettings_AuthorId",
                table: "TestSettings",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSettings_CourseId",
                table: "TestSettings",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PortraitId",
                table: "User",
                column: "PortraitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerOption");

            migrationBuilder.DropTable(
                name: "Config");

            migrationBuilder.DropTable(
                name: "EntitiesTags");

            migrationBuilder.DropTable(
                name: "QuestionSettings");

            migrationBuilder.DropTable(
                name: "Entities");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "TestSettings");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
