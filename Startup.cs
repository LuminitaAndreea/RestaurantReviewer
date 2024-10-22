using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestaurantReviewer.Interfaces;
using RestaurantReviewer.Models;
using RestaurantReviewer.Repositories;

namespace RestaurantReviewer
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
            var connection = @"Server=DESKTOP-VDTQMNM;Database=RestaurantReviewerDb2;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<Models.Context>
                (options => options.UseSqlServer(connection));
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => FavoriteCart.GetCart(sp));
            services.AddMvc();
            services.AddMemoryCache();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "send",
                    pattern: "{controller=Restaurants}/{action=SendReview}/{id?}");
                endpoints.MapControllerRoute(
                   name: "seereviews",
                   pattern: "{controller=Restaurants}/{action=ReviewList}/{id?}");

            });
        }
    }
}
