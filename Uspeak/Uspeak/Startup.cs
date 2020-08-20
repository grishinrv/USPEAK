using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using NLog;
using System;
using System.IO;
using Uspeak.Infrastructure;
using Uspeak.Infrastructure.Middleware;
using Uspeak.Persistence;
using Uspeak.Services;

namespace Uspeak
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });

            services.AddSingleton<Infrastructure.IConfigurationProvider>(x =>
                new Infrastructure.ConfigurationProvider(Configuration));
            services.AddSingleton<IContextFactory>(x =>
               new ContextFactory(Configuration.GetConnectionString("UspeakDatabase")));
            services.AddSingleton<IEntityRepository, EntityRepository>();
            services.AddSingleton<ITagRepository, TagRepository>();
            services.AddSingleton<ICourseRepository, CourseRepository>();
            services.AddSingleton<ILogger, Infrastructure.Logger>();
            services.AddDbContext<UspeakDbContext>(); //только для первичного создания БД через Update-Database

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseExceptionHandler("/Error");
            if (!env.IsDevelopment())
                app.UseHsts();


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseRouting();
            app.UseMiddleware<RequestLogger>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
