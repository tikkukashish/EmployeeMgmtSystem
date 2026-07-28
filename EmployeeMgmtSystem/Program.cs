using EmployeeMgmtSystem.DAL;
using EmployeeMgmtSystem.Repository;
using Microsoft.EntityFrameworkCore;

namespace EmployeeMgmtSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var cs = builder.Configuration.GetConnectionString("con");
            builder.Services.AddDbContext<EmployeeDbContext>(options => options.UseSqlServer(cs));

            builder.Services.AddTransient<IEmployeeRepo, EmployeeRepo>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Employee}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
