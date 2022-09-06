using pdemo.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace pdemo
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
            //database
            services.AddDbContext<DBContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), mysqlOptions =>
                {
                    mysqlOptions.ServerVersion(new Version(8, 0, 29), ServerType.MySql);
                });
            });
            services.AddDbContext<TicketsContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), mysqlOptions =>
                {
                    mysqlOptions.ServerVersion(new Version(8, 0, 29), ServerType.MySql);
                });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //database
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DBContext dbContext ,TicketsContext ticketsContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //database
            dbContext.Database.EnsureCreated();
            ticketsContext.Database.EnsureCreated();
        }
    }
}

