using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using Uspeak.Data.Models;
using Uspeak.Data.Models.Courses;
using Uspeak.Data.Models.Infrastructure;
using Uspeak.Infrastructure;

namespace Uspeak.Persistence
{
    public class UspeakDbContext : DbContext, IUspeakDbContext
    {
        public UspeakDbContext(DbContextOptions<UspeakDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Метод нужен для поддержки создания миграций в designTime
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected sealed override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("UspeakDatabase"));
            optionsBuilder.UseLoggerFactory(LoggerFactoryMethod);
        }

        public static readonly ILoggerFactory LoggerFactoryMethod = LoggerFactory.Create(builder =>
        {
            builder.AddProvider(new SqlQueryLoggerProvider()); 
        });

        protected sealed override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RuntimeConfiguration>()
                .HasKey(x => x.Key);

            modelBuilder.Entity<Entity>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<EntityTag>()
                .HasKey(x => new { x.EntityId, x.TagId });

            modelBuilder.Entity<EntityTag>()
               .HasOne(sc => sc.Entity)
               .WithMany(s => s.EntityTags)
               .HasForeignKey(sc => sc.EntityId);

            modelBuilder.Entity<EntityTag>()
                .HasOne(sc => sc.Tag)
                .WithMany(c => c.EntityTags)
                .HasForeignKey(sc => sc.TagId);

            modelBuilder.Entity<Tag>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Image>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Course>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Course>()
                .HasOne(x => x.PromoImage);

            modelBuilder.Entity<RuntimeConfiguration>()
                .HasKey(x => x.Key);

            //modelBuilder.Entity<User>().

            var createdTime = new DateTime(year: 2020, month: 8, day: 6, hour: 8, minute: 0, second: 0);
            modelBuilder.Entity<Entity>().HasData(
            #region Английский
                new Entity()
                {
                    Id = new Guid("30bc01bf-8cbe-4252-a5f6-4017f601c8c3"),
                    Name = "Подготовка к школе с английским языком",
                    Description = @"Курс поможет Вашему ребенку подготовиться к школе не только по основным предметам, 
                        но и включает в себя занятия английским. В ходе занятий ребенок в игровой форме познакомиться 
                        с русским и английским  алфавитами, научится читать на русском и английском, научится считать. 
                        Курс поможет развитию логики, любознательности и не отпугнет желание ребенка учиться. 
                        Занятия проходят в мини-группах (до 4 человек ), что обеспечивает индивидуальный подход к каждому малышу.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("73ccf858-3467-4a6b-a8ac-ee7cfc85f620"),
                    Name = "Общий курс по английскому для детей и подростков ( от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("0bd380cf-78af-4338-a508-bc41afe6c1af"),
                    Name = "Общий курс английского для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("59ac3930-3825-4cb2-9fe7-4ff499947176"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов языка. 
                        Особое внимание уделяется рассмотрению специфики тестовых заданий, 
                        а также методики их выполнения. Также в ходе курса предусмотрены пробные тестирования 
                        с тренировкой заполнения бланков.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"),
                    Name = "Туристический английский",
                    Description = @"Если вы хотите общаться без помощи гида в отеле, аэропорту, гостинице или в городе, тогда этот курс для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("a032649c-5f7d-4a64-b13b-468f46764e98"),
                    Name = "Кинозал на английском",
                    Description = @"Отличный способ отдохнуть с пользой. Кинозал открыт как для детей, так и для взрослых. 
                        Мы смотрим фильмы в оригинале. Перед просмотром каждый получает рабочую тетрадь, 
                        в которой подготовлены и разобраны лексические (слова) и грамматические аспекты, 
                        встречаемые в фильме. Все это поможет комфортно и понятно 😊 посмотреть фильм. 
                        После кино-сеанса мы, конечно, обсудим фильм и все, возможно, появившиеся вопросы.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("b975c806-db88-414c-9e00-9d245ac7acc9"),
                    Name = "Английский разговорный клуб “Tea and talk”",
                    Description = @"За чашкой чая поболтаем на английском с носителем языка. 
                        Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер.
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
            #endregion
            #region Немецкий
                new Entity()
                {
                    Id = new Guid("5da65f09-8783-4eae-9d77-658c63b11116"),
                    Name = "Общий курс по немецкому для детей и подростков (от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("91cfb955-12a6-464a-b8f1-87b40c25fce7"),
                    Name = "Общий курс немецкого для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("c182e464-9ccb-4e26-812f-4c90d178f57f"),
                    Name = "Разговорный немецкий",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
            #endregion
            #region Французский
                new Entity()
                {
                    Id = new Guid("59baec0a-54f7-4b35-bb09-53df0468f198"),
                    Name = "Общий курс по французскому для детей и подростков ( от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("6e77f097-c273-42f6-bb1e-bf0d25b1bbe7"),
                    Name = "Общий курс французского для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("df87b337-60b6-4011-b781-3cd2d8dce904"),
                    Name = "Разговорный французский",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
            #endregion
            #region Итальянский
                new Entity()
                {
                    Id = new Guid("8b4739e7-61d1-4213-8e61-433c91a87a1e"),
                    Name = "Общий курс по итальянскому для детей и подростков ( от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("872e64dd-fcd5-4650-b454-17d82f43a2a7"),
                    Name = "Общий курс итальянского для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("0ff2e69b-05fa-4e3c-8f16-b85e699baee3"),
                    Name = "Разговорный итальянский",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
            #endregion
            #region Китайский
                new Entity()
                {
                    Id = new Guid("59cbe049-bc81-4f19-9264-707ac2734d77"),
                    Name = "Общий курс по китайскому для детей и подростков ( от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("32a53c0f-87ff-403d-b3f2-7aa978c37531"),
                    Name = "Общий курс китайского для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
            #endregion
            #region Математика
                new Entity()
                {
                    Id = new Guid("b18c7332-bbbd-44bf-987e-313f43fd55e0"),
                    Name = "Курс для дошкольников",
                    Description = @"Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.
                        Занятие ведет опытный педагог, который найдет ключик к любому малышу. 
                        Занятия могут быть как индивидуальными, так и в мини-группе (до 3 человек)",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"),
                    Name = "Курс для детей младшей,  средней  и старшей школы",
                    Description = @"Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов предмета. 
                        Особое внимание уделяется рассмотрению специфики тестовых заданий, а также методики их выполнения. 
                        Также в ходе курса предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
            #endregion
            # region Физика
                new Entity()
                {
                    Id = new Guid("38e207fc-de41-47fa-bb9b-912e83328896"),
                    Name = "Курс для детей средней и старшей школы",
                    Description = @"Курс направлен на развитие и углубление знаний, а также на устранение пробелов знаний.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("89268a4f-1774-401f-8083-d2b316c20975"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов языка. 
                        Особое внимание уделяется рассмотрению специфики тестовых заданий, 
                        а также методики их выполнения. Также в ходе курса предусмотрены пробные тестирования 
                        с тренировкой заполнения бланков.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
            #endregion
            #region Развивайка
                new Entity()
                {
                    Id = new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"),
                    Name = "Обучение чтению на основе кубиков Зайцева",
                    Description = @"«Кубики Зайцева» — пособие для обучения чтению с двух лет. 
                        Эта методика обучения чтению прошла испытание временем, ведь уже более 20 лет она пользуется 
                        огромной популярностью как среди родителей, так и педагогов дошкольных учреждений. 
                        Обучение с помощью кубиков  обеспечивает наглядность  и системность подачи материала. 
                        Занятия проходят в игровой форме.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
            #endregion
            #region Русский язык
                new Entity()
                {
                    Id = new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"),
                    Name = "Курс для дошкольников",
                    Description = @"Курс направлен на развитие знаний по русскому языку.
                        Занятие ведет опытный педагог, который найдет ключик к любому малышу. 
                        Занятия могут быть как индивидуальными, так и в мини-группе (до 3 человек).",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("509c15b7-438c-4927-b586-2747791b2a63"),
                    Name = "Курс для детей младшей,  средней  и старшей школы",
                    Description = @"Курс направлен на развитие знаний русского языка, а также на устранение пробелов знаний.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов предмета. Особое внимание уделяется 
                        рассмотрению специфики тестовых заданий , а также методики их выполнения. Также в ходе курса
                        предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime,
                    Status = EntityStatus.Published,
                    StatusChangedTime = createdTime
                });
            #endregion

            modelBuilder.Entity<EntityTag>().HasData(
                new EntityTag()
                {
                    EntityId = new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"),
                    TagId = new Guid("2b474a26-76d2-45ee-be3e-f38eca83d9ee")
                },
                new EntityTag()
                {
                    EntityId = new Guid("38e207fc-de41-47fa-bb9b-912e83328896"),
                    TagId = new Guid("a6eecf1c-207a-4214-9897-bb2403aaf9d0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("38e207fc-de41-47fa-bb9b-912e83328896"),
                    TagId = new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("89268a4f-1774-401f-8083-d2b316c20975"),
                    TagId = new Guid("a6eecf1c-207a-4214-9897-bb2403aaf9d0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("89268a4f-1774-401f-8083-d2b316c20975"),
                    TagId = new Guid("1dceded6-3990-4cb3-bc2e-936d0ae7f79d")
                },
                new EntityTag()
                {
                    EntityId = new Guid("b18c7332-bbbd-44bf-987e-313f43fd55e0"),
                    TagId = new Guid("2b474a26-76d2-45ee-be3e-f38eca83d9ee")
                },
                new EntityTag()
                {
                    EntityId = new Guid("b18c7332-bbbd-44bf-987e-313f43fd55e0"),
                    TagId = new Guid("866787e8-9e2e-48ae-aedd-0dcbafa5edcc")
                },
                new EntityTag()
                {
                    EntityId = new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"),
                    TagId = new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"),
                    TagId = new Guid("866787e8-9e2e-48ae-aedd-0dcbafa5edcc")
                },
                new EntityTag()
                {
                    EntityId = new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"),
                    TagId = new Guid("866787e8-9e2e-48ae-aedd-0dcbafa5edcc")
                },
                new EntityTag()
                {
                    EntityId = new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"),
                    TagId = new Guid("1dceded6-3990-4cb3-bc2e-936d0ae7f79d")
                },
                new EntityTag()
                {
                    EntityId = new Guid("59cbe049-bc81-4f19-9264-707ac2734d77"),
                    TagId = new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("59cbe049-bc81-4f19-9264-707ac2734d77"),
                    TagId = new Guid("bf53a489-cdca-47c0-ac5c-3437c47c19c6")
                },
                new EntityTag()
                {
                    EntityId = new Guid("32a53c0f-87ff-403d-b3f2-7aa978c37531"),
                    TagId = new Guid("bf53a489-cdca-47c0-ac5c-3437c47c19c6")
                },
                new EntityTag()
                {
                    EntityId = new Guid("32a53c0f-87ff-403d-b3f2-7aa978c37531"),
                    TagId = new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5")
                },
                new EntityTag()
                {
                    EntityId = new Guid("8b4739e7-61d1-4213-8e61-433c91a87a1e"),
                    TagId = new Guid("b66d4365-0bb7-4ea0-9c63-86166aec8aa3")
                },
                new EntityTag()
                {
                    EntityId = new Guid("8b4739e7-61d1-4213-8e61-433c91a87a1e"),
                    TagId = new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("872e64dd-fcd5-4650-b454-17d82f43a2a7"),
                    TagId = new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5")
                },
                new EntityTag()
                {
                    EntityId = new Guid("872e64dd-fcd5-4650-b454-17d82f43a2a7"),
                    TagId = new Guid("b66d4365-0bb7-4ea0-9c63-86166aec8aa3")
                },
                new EntityTag()
                {
                    EntityId = new Guid("0ff2e69b-05fa-4e3c-8f16-b85e699baee3"),
                    TagId = new Guid("b66d4365-0bb7-4ea0-9c63-86166aec8aa3")
                },
                new EntityTag()
                {
                    EntityId = new Guid("59baec0a-54f7-4b35-bb09-53df0468f198"),
                    TagId = new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("59baec0a-54f7-4b35-bb09-53df0468f198"),
                    TagId = new Guid("c4e7b67e-809a-40d2-a222-0a12f35ba22f")
                },
                new EntityTag()
                {
                    EntityId = new Guid("6e77f097-c273-42f6-bb1e-bf0d25b1bbe7"),
                    TagId = new Guid("c4e7b67e-809a-40d2-a222-0a12f35ba22f")
                },
                new EntityTag()
                {
                    EntityId = new Guid("6e77f097-c273-42f6-bb1e-bf0d25b1bbe7"),
                    TagId = new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5")
                },
                new EntityTag()
                {
                    EntityId = new Guid("df87b337-60b6-4011-b781-3cd2d8dce904"),
                    TagId = new Guid("c4e7b67e-809a-40d2-a222-0a12f35ba22f")
                },
                new EntityTag()
                {
                    EntityId = new Guid("5da65f09-8783-4eae-9d77-658c63b11116"),
                    TagId = new Guid("fff0e828-e9c8-4ae5-b33a-df1c1f23f874")
                },
                new EntityTag()
                {
                    EntityId = new Guid("5da65f09-8783-4eae-9d77-658c63b11116"),
                    TagId = new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("91cfb955-12a6-464a-b8f1-87b40c25fce7"),
                    TagId = new Guid("fff0e828-e9c8-4ae5-b33a-df1c1f23f874")
                },
                new EntityTag()
                {
                    EntityId = new Guid("91cfb955-12a6-464a-b8f1-87b40c25fce7"),
                    TagId = new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5")
                },
                new EntityTag()
                {
                    EntityId = new Guid("c182e464-9ccb-4e26-812f-4c90d178f57f"),
                    TagId = new Guid("fff0e828-e9c8-4ae5-b33a-df1c1f23f874")
                },
                new EntityTag()
                {
                    EntityId = new Guid("30bc01bf-8cbe-4252-a5f6-4017f601c8c3"),
                    TagId = new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430")
                },
                new EntityTag()
                {
                    EntityId = new Guid("30bc01bf-8cbe-4252-a5f6-4017f601c8c3"),
                    TagId = new Guid("2b474a26-76d2-45ee-be3e-f38eca83d9ee")
                },
                new EntityTag()
                {
                    EntityId = new Guid("73ccf858-3467-4a6b-a8ac-ee7cfc85f620"),
                    TagId = new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430")
                },
                new EntityTag()
                {
                    EntityId = new Guid("73ccf858-3467-4a6b-a8ac-ee7cfc85f620"),
                    TagId = new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0")
                },
                new EntityTag()
                {
                    EntityId = new Guid("0bd380cf-78af-4338-a508-bc41afe6c1af"),
                    TagId = new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430")
                },
                new EntityTag()
                {
                    EntityId = new Guid("0bd380cf-78af-4338-a508-bc41afe6c1af"),
                    TagId = new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5")
                },
                new EntityTag()
                {
                    EntityId = new Guid("59ac3930-3825-4cb2-9fe7-4ff499947176"),
                    TagId = new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430")
                },
                new EntityTag()
                {
                    EntityId = new Guid("59ac3930-3825-4cb2-9fe7-4ff499947176"),
                    TagId = new Guid("1dceded6-3990-4cb3-bc2e-936d0ae7f79d")
                },
                new EntityTag()
                {
                    EntityId = new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"),
                    TagId = new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430")
                },
                new EntityTag()
                {
                    EntityId = new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"),
                    TagId = new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5")
                },
                new EntityTag()
                {
                    EntityId = new Guid("b975c806-db88-414c-9e00-9d245ac7acc9"),
                    TagId = new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430")
                },
                new EntityTag()
                {
                    EntityId = new Guid("a032649c-5f7d-4a64-b13b-468f46764e98"),
                    TagId = new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430")
                },
                new EntityTag()
                {
                    EntityId = new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"),
                    TagId = new Guid("900c8402-e705-489d-a651-3336e37086b2")
                },
                new EntityTag()
                {
                    EntityId = new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"),
                    TagId = new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd")
                },
                new EntityTag()
                {
                    EntityId = new Guid("509c15b7-438c-4927-b586-2747791b2a63"),
                    TagId = new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd")
                },
                new EntityTag()
                {
                    EntityId = new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"),
                    TagId = new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd")
                });

            modelBuilder.Entity<Course>().HasData(
            #region Английский
                 new Course()
                 {
                     Id = new Guid("30bc01bf-8cbe-4252-a5f6-4017f601c8c3"),
                     Name = "Подготовка к школе с английским языком",
                     Description = @"Курс поможет Вашему ребенку подготовиться к школе не только по основным предметам, 
                        но и включает в себя занятия английским. В ходе занятий ребенок в игровой форме познакомиться 
                        с русским и английским  алфавитами, научится читать на русском и английском, научится считать. 
                        Курс поможет развитию логики, любознательности и не отпугнет желание ребенка учиться. 
                        Занятия проходят в мини-группах (до 4 человек ), что обеспечивает индивидуальный подход к каждому малышу.",
                     CssClassesString = "eng children"
                 },
                new Course()
                {
                    Id = new Guid("73ccf858-3467-4a6b-a8ac-ee7cfc85f620"),
                    Name = "Общий курс по английскому для детей и подростков ( от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка: 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "eng teenagers"
                },
                new Course()
                {
                    Id = new Guid("0bd380cf-78af-4338-a508-bc41afe6c1af"),
                    Name = "Общий курс английского для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка: 
                        говорение, грамматика, аудирование, фонетика,  чтение  и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "eng adults"
                },
                new Course()
                {
                    Id = new Guid("59ac3930-3825-4cb2-9fe7-4ff499947176"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов языка. 
                        Особое внимание уделяется рассмотрению специфики тестовых заданий, 
                        а также методики их выполнения. Также в ходе курса предусмотрены пробные тестирования 
                        с тренировкой заполнения бланков.",
                    CssClassesString = "eng exam"
                },
                new Course()
                {
                    Id = new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"),
                    Name = "Туристический английский",
                    Description = @"Если вы хотите общаться без помощи гида в отеле, аэропорту, гостинице или в городе, тогда этот курс для Вас.",
                    CssClassesString = "eng adults"
                },
                new Course()
                {
                    Id = new Guid("a032649c-5f7d-4a64-b13b-468f46764e98"),
                    Name = "Кинозал на английском",
                    Description = @"Отличный способ отдохнуть с пользой. Кинозал открыт как для детей, так и для взрослых. 
                        Мы смотрим фильмы в оригинале. Перед просмотром каждый получает рабочую тетрадь, 
                        в которой подготовлены и разобраны лексические (слова) и грамматические аспекты, 
                        встречаемые в фильме. Все это поможет комфортно и понятно 😊 посмотреть фильм. 
                        После кино-сеанса мы, конечно, обсудим фильм и все, возможно, появившиеся вопросы.",
                    CssClassesString = "eng"
                },
                new Course()
                {
                    Id = new Guid("b975c806-db88-414c-9e00-9d245ac7acc9"),
                    Name = "Английский разговорный клуб “Tea and talk”",
                    Description = @"За чашкой чая поболтаем на английском с носителем языка. 
                        Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер.
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    CssClassesString = "eng"
                },
            #endregion
            #region Немецкий
                new Course()
                {
                    Id = new Guid("5da65f09-8783-4eae-9d77-658c63b11116"),
                    Name = "Общий курс по немецкому для детей и подростков (от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка: 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "de teenagers"
                },
                new Course()
                {
                    Id = new Guid("91cfb955-12a6-464a-b8f1-87b40c25fce7"),
                    Name = "Общий курс немецкого для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка: 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "de adults"
                },
                new Course()
                {
                    Id = new Guid("c182e464-9ccb-4e26-812f-4c90d178f57f"),
                    Name = "Разговорный немецкий",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    CssClassesString = "de"
                },
            #endregion
            #region Французский
                new Course()
                {
                    Id = new Guid("59baec0a-54f7-4b35-bb09-53df0468f198"),
                    Name = "Общий курс по французскому для детей и подростков ( от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "fr teenagers"
                },
                new Course()
                {
                    Id = new Guid("6e77f097-c273-42f6-bb1e-bf0d25b1bbe7"),
                    Name = "Общий курс французского для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка: 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "fr adults"
                },
                new Course()
                {
                    Id = new Guid("df87b337-60b6-4011-b781-3cd2d8dce904"),
                    Name = "Разговорный французский",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    CssClassesString = "fr"
                },
            #endregion
            #region Итальянский
                new Course()
                {
                    Id = new Guid("8b4739e7-61d1-4213-8e61-433c91a87a1e"),
                    Name = "Общий курс по итальянскому для детей и подростков ( от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "it teenagers"
                },
                new Course()
                {
                    Id = new Guid("872e64dd-fcd5-4650-b454-17d82f43a2a7"),
                    Name = "Общий курс итальянского для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "it adults"
                },
                new Course()
                {
                    Id = new Guid("0ff2e69b-05fa-4e3c-8f16-b85e699baee3"),
                    Name = "Разговорный итальянский",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    CssClassesString = "it"
                },
            #endregion
            #region Китайский
                new Course()
                {
                    Id = new Guid("59cbe049-bc81-4f19-9264-707ac2734d77"),
                    Name = "Общий курс по китайскому для детей и подростков ( от 5 лет)",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "ch teenagers"
                },
                new Course()
                {
                    Id = new Guid("32a53c0f-87ff-403d-b3f2-7aa978c37531"),
                    Name = "Общий курс китайского для взрослых",
                    Description = @"Общий курс подразумевает изучение основных аспектов языка : 
                        говорение, грамматика, аудирование, фонетика, чтение и письмо. 
                        Этот курс походит для любого уровня владения языком – курс будет подобран индивидуально для Вас. 
                        Занятия могут быть в группе и индивидуально, как в студии, так и on-line.",
                    CssClassesString = "ch adults"
                },
            #endregion
            #region Математика
                new Course()
                {
                    Id = new Guid("b18c7332-bbbd-44bf-987e-313f43fd55e0"),
                    Name = "Курс для дошкольников",
                    Description = @"Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.
                        Занятие ведет опытный педагог, который найдет ключик к любому малышу. 
                        Занятия могут быть как индивидуальными, так и в мини-группе (до 3 человек)",
                    CssClassesString = "math children"
                },
                new Course()
                {
                    Id = new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"),
                    Name = "Курс для детей младшей, средней и старшей школы",
                    Description = @"Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.",
                    CssClassesString = "math teenagers"
                },
                new Course()
                {
                    Id = new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов предмета. 
                        Особое внимание уделяется рассмотрению специфики тестовых заданий, а также методики их выполнения. 
                        Также в ходе курса предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.",
                    CssClassesString = "math exam"
                },
            #endregion
            # region Физика
                new Course()
                {
                    Id = new Guid("38e207fc-de41-47fa-bb9b-912e83328896"),
                    Name = "Курс для детей средней и старшей школы",
                    Description = @"Курс направлен на развитие и углубление знаний, а также на устранение пробелов знаний.",
                    CssClassesString = "physics teenagers"
                },
                new Course()
                {
                    Id = new Guid("89268a4f-1774-401f-8083-d2b316c20975"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов языка. 
                        Особое внимание уделяется рассмотрению специфики тестовых заданий, 
                        а также методики их выполнения. Также в ходе курса предусмотрены пробные тестирования 
                        с тренировкой заполнения бланков.",
                    CssClassesString = "physics exam"
                },
            #endregion
            #region Развивайка
                new Course()
                {
                    Id = new Guid("0b5c416f-4bd6-43c2-86c7-f37bb9284a01"),
                    Name = "Обучение чтению на основе кубиков Зайцева",
                    Description = @"«Кубики Зайцева» — пособие для обучения чтению с двух лет. 
                        Эта методика обучения чтению прошла испытание временем, ведь уже более 20 лет она пользуется 
                        огромной популярностью как среди родителей, так и педагогов дошкольных учреждений. 
                        Обучение с помощью кубиков  обеспечивает наглядность и системность подачи материала. 
                        Занятия проходят в игровой форме.",
                    CssClassesString = "evo children"
                },
            #endregion
            #region Русский язык
                new Course()
                {
                    Id = new Guid("c56b171c-77fe-41ac-9da9-d2118edd4077"),
                    Name = "Курс для дошкольников",
                    Description = @"Курс направлен на развитие знаний по русскому языку.
                            Занятие ведет опытный педагог, который найдет ключик к любому малышу. 
                            Занятия могут быть как индивидуальными, так и в мини-группе (до 3 человек).",
                    CssClassesString = "ru children"
                },
                new Course()
                {
                    Id = new Guid("509c15b7-438c-4927-b586-2747791b2a63"),
                    Name = "Курс для детей младшей,  средней  и старшей школы",
                    Description = @"Курс направлен на развитие знаний русского языка, а также на устранение пробелов знаний.",
                    CssClassesString = "ru teenages"
                },
                new Course()
                {
                    Id = new Guid("1b9b3807-3560-4f9a-a427-87c9d3a42f9b"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов предмета. Особое внимание уделяется 
                        рассмотрению специфики тестовых заданий , а также методики их выполнения. Также в ходе курса
                        предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.",
                    CssClassesString = "ru exam"
                });
            #endregion

            modelBuilder.Entity<Tag>().HasData(
                new Tag()
                {
                    Id = new Guid("d1a18186-9b28-4e8c-8d2b-958c0658c9f5"),
                    Name = "для взрослых",
                    TagKind = TagType.TargetAaudience,
                    CssClass = "adults"
                },
                new Tag()
                {
                    Id = new Guid("bf53a489-cdca-47c0-ac5c-3437c47c19c6"),
                    Name = "Китайский",
                    TagKind = TagType.StudySubject,
                    CssClass = "ch"
                },
                new Tag()
                {
                    Id = new Guid("2b474a26-76d2-45ee-be3e-f38eca83d9ee"),
                    Name = "для детей",
                    TagKind = TagType.TargetAaudience,
                    CssClass = "children"
                },
                new Tag()
                {
                    Id = new Guid("fff0e828-e9c8-4ae5-b33a-df1c1f23f874"),
                    Name = "Немецкий",
                    TagKind = TagType.StudySubject,
                    CssClass = "de"
                },
                new Tag()
                {
                    Id = new Guid("7c34639f-fa83-4182-b0d1-a117e95f9430"),
                    Name = "Английский",
                    TagKind = TagType.StudySubject,
                    CssClass = "eng"
                },
                new Tag()
                {
                    Id = new Guid("1dceded6-3990-4cb3-bc2e-936d0ae7f79d"),
                    Name = "Подготовка к экзаменам",
                    TagKind = TagType.Goal,
                    CssClass = "exam"
                },
                new Tag()
                {
                    Id = new Guid("c4e7b67e-809a-40d2-a222-0a12f35ba22f"),
                    Name = "Французский",
                    TagKind = TagType.StudySubject,
                    CssClass = "fr"
                },
                new Tag()
                {
                    Id = new Guid("b66d4365-0bb7-4ea0-9c63-86166aec8aa3"),
                    Name = "Итальянский",
                    TagKind = TagType.StudySubject,
                    CssClass = "it"
                },
                new Tag()
                {
                    Id = new Guid("866787e8-9e2e-48ae-aedd-0dcbafa5edcc"),
                    Name = "Математика",
                    TagKind = TagType.StudySubject,
                    CssClass = "math"
                },
                new Tag()
                {
                    Id = new Guid("a6eecf1c-207a-4214-9897-bb2403aaf9d0"),
                    Name = "Физика",
                    TagKind = TagType.StudySubject,
                    CssClass = "physics"
                },
                new Tag()
                {
                    Id = new Guid("9608a36e-6e89-4852-bab4-c4c06454c1f0"),
                    Name = "детей средней и старшей школы",
                    TagKind = TagType.TargetAaudience,
                    CssClass = "teenagers"
                },
                new Tag()
                {
                    Id = new Guid("900c8402-e705-489d-a651-3336e37086b2"),
                    Name = "Развивайка",
                    TagKind = TagType.StudySubject,
                    CssClass = "evo"
                },
                new Tag()
                {
                    Id = new Guid("1ae1711c-c8c0-4692-b82f-a317f2ce6ecd"),
                    Name = "Русский язык",
                    TagKind = TagType.StudySubject,
                    CssClass = "ru"
                }
            );

            modelBuilder.Entity<RuntimeConfiguration>()
                .HasData(
                    new RuntimeConfiguration()
                    { 
                        Key = "about_us_full_text",
                        Value = @"Привет! Мы рады видеть Вас! Наша студия – это небольшое, но очень уютное пространство, 
где найдется место каждому! Мы делаем все, чтобы приходя к нам за знаниями, 
Вы получали их на высоком уровне, при этом также росли культурно и находили новых друзей. 
Знания – это ключ к понимаю мира, который может подарить Вам множество возможностей. Добро пожаловать!"
                    },
                    new RuntimeConfiguration()
                    {
                        Key = "about_us_short_text",
                        Value = "Знания – ключ к пониманию мира, дарящий нам множество возможностей."
                    }
                );
        }

        public DbSet<Course> Courses { get; set; }

        //public DbSet<EventInstance> Events { get; set; }

        public DbSet<RuntimeConfiguration> Config { get; set; }

        //public DbSet<Group> Groups { get; set; }

        //public DbSet<Lesson> Lessons { get; set; }

        //public DbSet<LessonStudentPresence> Presences { get; set; }

        //public DbSet<Student> Students { get; set; }

        //public DbSet<Teacher> Teachers { get; set; }

        //public DbSet<AnswerOption> AnswerOptions { get; set; }

        //public DbSet<QuestionSettings> QuestionSettings { get; set; }

        //public DbSet<TestSettings> TestSettings { get; set; }

        //public DbSet<User> Users { get; set; }

        public DbSet<Entity> Entities { get; set; }

        public DbSet<Tag> Tags { get; set; }
        
        public DbSet<Image> Images { get; set; }

        public DbSet<EntityTag> EntitiesTags { get; set; }
    }
}
