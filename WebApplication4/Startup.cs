using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MvcProject;
using MvcProject.Models;
using MvcProject.Repositories;

namespace WebApplication4
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepository<Product>, ProductRepository>();
            services.AddScoped<IRepository<Review>, ReviewRepository>();
            services.AddMvc();
            services.AddDbContext<VehicleContext>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Product/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Product}/{action=Index}/{id?}");
            });
        }
    }
}
