using Microsoft.EntityFrameworkCore;
using ServerManagement.Components;
using ServerManagement.Data;
using ServerManagement.Models;
using ServerManagement.StateStoreExamples;


namespace ServerManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents().AddInteractiveServerComponents(); // this chained method for using SSR. see also below in the app section.

            // for using the session storage in the clients browser
            builder.Services.AddTransient<SessionStorageContainer>();
            builder.Services.AddScoped<DiServerContainer>();

            // for using an observer per City
            builder.Services.AddScoped<TorontoOnlineServersStore>();
            builder.Services.AddScoped<MontrealOnlineServersStore>();
            builder.Services.AddScoped<OttawaOnlineServersStore>();
            builder.Services.AddScoped<CalgaryOnlineServersStore>();
            builder.Services.AddScoped<HalifaxOnlineServersStore>();

            builder.Services.AddDbContextFactory<ServerManagementDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ServerManagementDbFrankLiu"));
                options.EnableDetailedErrors();
                options.EnableSensitiveDataLogging();
            }
            );
            
            // for interacting with the data
            builder.Services.AddTransient<IServersEFCoreRepository, ServersEFCoreRepository>();

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
            app.UseAntiforgery();

            app.MapRazorComponents<App>().AddInteractiveServerRenderMode();


            app.Run();
        }
    }
}
