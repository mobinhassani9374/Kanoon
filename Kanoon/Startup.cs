﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Kanoon.Data.Context;
using Microsoft.EntityFrameworkCore;
using Kanoon.Data;
using Kanoon.DomainModels.Entities;
using Kanoon.Data.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Kanoon
{
    public class Startup
    {
        private readonly IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment env)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile(path: "appsetting.json", optional: false, reloadOnChange: true)
                .Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection"));
            });

            // add repository
            services.AddScoped<Data.BaseRepository<Location>>();
            services.AddScoped<HeiatRepository>();
            services.AddScoped<UserRepository>();

            Bootstraper.Mapping.Initializer.Initial();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.AccessDeniedPath = "/accessDenied";
                    options.LoginPath = "/login";
                    options.LogoutPath = "/logout";
                });

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, AppDbContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            db.Database.Migrate();

            DatabaseInitializer.Seed(db);

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseMvcWithDefaultRoute();
        }
    }
}
