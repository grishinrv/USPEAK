using Microsoft.AspNetCore.Mvc.Formatters;
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
