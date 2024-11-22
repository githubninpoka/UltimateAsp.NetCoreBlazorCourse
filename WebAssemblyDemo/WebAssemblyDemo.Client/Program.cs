using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace WebAssemblyDemo.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddScoped<DiContainerStorage>();
            // be aware that with WebAssembly, you also need to register this class as a service in the server project.
            // because of pre-rendering.

            await builder.Build().RunAsync();
        }
    }
}
