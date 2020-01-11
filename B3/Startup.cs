using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B3.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace B3
{
    public class Startup
    {
        //Constructor that we need in order to get the property "GetConnectionString"
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Adding all the services that we are going to use in our application (Some are Built-in, some are our own)

            //Configure app so its knows about Entity Framework Core ---> Database
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Bringing functionality for working with Identity using Entity
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();

            //Register repositories in order to use them
            //Mock repositories before we implement database
            //services.AddScoped<IPastryRepository, MockPastryRepository>();
            //services.AddScoped<IPastryCategoryRepository, MockPastryCategoryRepository>();
            services.AddScoped<IPastryRepository, PastryRepository>();
            services.AddScoped<IPastryCategoryRepository, PastryCategoryRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();


            //Adding support for working with MVC 
            services.AddControllersWithViews();

            //Adding support for Razor Pages from Identity
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Enviroment Check and if its in development we get Exception Pages
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Adding more MiddleWare Components

            //HTTPS request instead of HTTP
            app.UseHttpsRedirection();

            //Making sure our application uses files like Images, CSS ...
            app.UseStaticFiles();

            //With Use Routing and Use EndPoints we enable the MVC to respond to incoming requests (mapping request)
            app.UseRouting();

            //Enable to authenticate using Identity
            app.UseAuthentication();

            //Enabling Authorization for only our logged-in user to use specific parts and functions off our app
            app.UseAuthorization(); 


            app.UseEndpoints(endpoints =>
            {
                //Mapping incoming request with action on a controller
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //Adding an endpoint in order to work with Identity and read our RazorPages
                endpoints.MapRazorPages();
            });
        }
    }
}
