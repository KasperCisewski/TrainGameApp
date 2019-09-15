using System;
using System.Runtime.InteropServices;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrainQuiz_BackEnd.Data.Context;
using TrainQuiz_BackEnd.Ioc;

namespace TrainQuiz_BackEnd
{
    public class Startup
    {
        public Startup(IHostingEnvironment environment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }
        public IContainer ApplicationContainer { get; private set; }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                services.AddEntityFrameworkSqlite().AddDbContext<TrainsQuizContext>(options =>
                    options.UseSqlite(Configuration.GetConnectionString("SqliteConnectionString")));
            }
            else
            {
                services.AddEntityFrameworkSqlServer().AddDbContext<TrainsQuizContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConnectionString")));

            }
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterModule(new ContainerModule(Configuration));
            ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(ApplicationContainer);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app.UseCors(options => options.WithOrigins("*").AllowAnyMethod());

            app.UseWebSockets();
            app.UseMiddleware<ChatWebSocketMiddleware>();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

