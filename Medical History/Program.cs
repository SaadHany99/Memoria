using Medical_History.Data;
using Medical_History.Models;
using Medical_History.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Medical_History
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<ApplicationDbContext>(op =>
            op.UseSqlServer(builder.Configuration.GetConnectionString("constr")));

            //Registering Repository in IOC Container.

            builder.Services.AddScoped<IRepository<Patient>,Repository<Patient>>();
            //builder.Services.AddScoped<IRepository<Doctor>,Repository<Doctor>>();
            //builder.Services.AddScoped<IRepository<Hospital>,Repository<Hospital>>();
            //builder.Services.AddScoped<IRepository<MedicalRecord>,Repository<MedicalRecord>>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
