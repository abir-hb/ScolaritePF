using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Scolarite.Domain.entities;
using Scolarite.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScolariteWeb
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
            services.AddScoped<IServiceClasse, ServiceClasse>();
            services.AddScoped<IServiceModule, ServiceModule>();
            services.AddScoped<IServiceENS, ServiceENS>();
            services.AddScoped<IServiceUE, ServiceUE>();
            services.AddScoped<IServiceUp, ServiceUp>();
            services.AddScoped<IPlanEService, PlanEService>();
            services.AddTransient<ModelContext>();
            services.AddMvcCore();
            services.AddRazorPages((options =>
            {
                options.Conventions.AuthorizeFolder("/Admin");
            }));

            
        // optionsBuilder
        services.AddDbContext<ModelContext>(options =>
        options.UseOracle(Configuration.GetConnectionString("oracledbCon")),
             ServiceLifetime.Transient);
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ModelContext>();

     
        
        //  services.AddDbContext<ModelContext>(options =>
        //    options.UseOracle(Configuration["Data:scopfeS:ConnectionString"]));

        //  services.AddDbContext<ModelContext>(options => options.UseOracle("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)));User Id=scopfeS;Password=esprit;"));




        services.AddMvc().AddRazorPagesOptions(Options =>
            {
                Options.Conventions.AddPageRoute("/Classe/List", "");
            });
            services.AddDistributedMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
             app.UseHttpsRedirection();
    app.UseStaticFiles();

            app.UseCookiePolicy();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=Login}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
