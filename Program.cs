using ClothingStore.Data;
using ClothingStore.Services;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages()
            .AddRazorRuntimeCompilation();

            builder.Services.AddScoped<ApplicationDbContext, ApplicationDbContext>();
            builder.Services.AddScoped<IProductService , ProductService>();
            builder.Services.AddScoped<IProviderService, ProviderService>();
            //builder.Services.AddScoped<IManufacturerService, ManufacturerService>();



            builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(
                    builder.Configuration.GetConnectionString("BloggingDatabaseContext")
                ));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}