namespace KidsFlixSystem
{
    using KidsFlixSystem.Data;
    using KidsFlixSystem.Data.Models;
    using KidsFlixSystem.Services.Data;
    using KidsFlixSystem.Services.Data.Interfaces;
    using KidsFlixSystem.Web.Infrastructure.Extentions;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;


    public class Program
	{
		public static void Main(string[] args)
		{
			WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


			string connectionString
				= builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<KidsFlixDbContext>(options =>
                            options.UseSqlServer(connectionString));


            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount =
                            builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                options.Password.RequireLowercase =
                                builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                options.Password.RequireUppercase =
                                builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                options.Password.RequireNonAlphanumeric =
                            builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");

                options.Password.RequiredLength =
                        builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
            })
                .AddEntityFrameworkStores<KidsFlixDbContext>();

            builder.Services.AddApplicationServices(typeof(IMovieService));
            builder.Services.AddControllersWithViews();

            WebApplication app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
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

			app.UseAuthentication();
			app.UseAuthorization();

			app.MapDefaultControllerRoute();
			app.MapRazorPages();

			app.Run();
		}
	}
}