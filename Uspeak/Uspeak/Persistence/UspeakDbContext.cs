﻿using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;
using Uspeak.Data.Models;
using Uspeak.Data.Models.Courses;
using Uspeak.Data.Models.Infrastructure;
using Uspeak.Data.Models.Study;
using Uspeak.Data.Models.Tests;
using Uspeak.Data.Models.Users;

namespace Uspeak.Persistence
{
    public class UspeakDbContext : DbContext, IUspeakDbContext
    {
        public UspeakDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        protected sealed override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Entity>()
                .HasMany(x => x.Tags)
                .WithOne(x => x.Enitity);

            modelBuilder.Entity<Tag>()
                .HasKey(x => new { x.EnityId, x.Name });

            modelBuilder.Entity<Image>()
                .HasKey(x => x.Id);

            modelBuilder.Entity<Course>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Course>()
                .HasOne(x => x.PromoImage);

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
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("c401cbbc-5e22-4360-b5c5-574167cc9cf8"),
                    Name = "Туристический английский",
                    Description = @"Если вы хотите общаться без помощи гида в отеле, аэропорту, гостинице или в городе, тогда этот курс для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("b975c806-db88-414c-9e00-9d245ac7acc9"),
                    Name = "Английский разговорный клуб “Tea and talk”",
                    Description = @"За чашкой чая поболтаем на английском с носителем языка. 
                        Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер.
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("c182e464-9ccb-4e26-812f-4c90d178f57f"),
                    Name = "Разговорный немецкий",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("df87b337-60b6-4011-b781-3cd2d8dce904"),
                    Name = "Разговорный французский",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("0ff2e69b-05fa-4e3c-8f16-b85e699baee3"),
                    Name = "Разговорный итальянский",
                    Description = @"Курс подойдет тем, кто хочет попрактиковать разговорную речь или наконец-то снять языковой барьер. 
                        Занятие будет комфортно для любого уровня – группа будет подобрана индивидуально для Вас.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("6bedac8d-367f-4157-ba9c-85bf06af4827"),
                    Name = "Курс для детей младшей,  средней  и старшей школы",
                    Description = @"Курс направлен на развитие математических знаний, а также на устранение пробелов знаний.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("eb04b082-1c7a-41bd-b48d-959fdb5fc77e"),
                    Name = "",
                    Description = @"",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
                },
                new Entity()
                {
                    Id = new Guid("ad2f81e7-8107-4eb5-8c11-9086335fe7c2"),
                    Name = "Подготовка к ОГЭ и ЕГЭ",
                    Description = @"Курс направлен на развитие всех аспектов предмета. 
                        Особое внимание уделяется рассмотрению специфики тестовых заданий, а также методики их выполнения. 
                        Также в ходе курса предусмотрены пробные тестирования с тренировкой заполнения экзаменационных бланков.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
                },
            #endregion
            # region Физика
                new Entity()
                {
                    Id = new Guid("38e207fc-de41-47fa-bb9b-912e83328896"),
                    Name = "Курс для детей средней и старшей школы",
                    Description = @"Курс направлен на развитие и углубление знаний, а также на устранение пробелов знаний.",
                    EnityKind = EntityType.Course,
                    CreatedTime = createdTime
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
                    CreatedTime = createdTime
                },
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
                    CreatedTime = createdTime
                });
            #endregion

        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<EventInstance> Events { get; set; }

        public DbSet<RuntimeConfiguration> Config { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Lesson> Lessons { get; set; }

        public DbSet<LessonStudentPresence> Presences { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<AnswerOption> AnswerOptions { get; set; }

        public DbSet<QuestionSettings> QuestionSettings { get; set; }

        public DbSet<TestSettings> TestSettings { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Entity> Entities { get; set; }

        public DbSet<Tag> Tags { get; set; }
        
        public DbSet<Image> Images { get; set; }
    }
}
