using DrinkAndGo.Data;
using DrinkStore.Data;
using DrinkStore.Data.Interfaces;
using DrinkStore.Data.mocks;
using DrinkStore.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace DrinkStore
{
    public class Startup
    {
        private readonly IConfiguration config;
        private IConfigurationRoot _configurationRoot;

        public Startup(IHostEnvironment hostingEnvironment,IConfiguration config)
        {
            this.config = config;
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            services.AddTransient<IDrinkRepo, DrinkRepository>();
            services.AddTransient<ICategoryRepo, CategoryRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
                                ILogger<Startup> logger, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            DbInitializer.Seed(serviceProvider);
        }
    }
}
