using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using AntDesign;
using UpscGeek.Core.Entities;
using UpscGeek.Core.Services.Base;
using UpscGeek.Infrastructure.FacadeServices;
using UpscGeek.Infrastructure.Services.Base;

namespace UpscGeek.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSingleton<SampleService>();
            builder.Services.AddAntDesign();
            builder.Services.AddHttpClient<IService<Subject>,Service<Subject>>(client =>
                {
                    client.BaseAddress = new Uri("https://localhost:5001/");
                }
            );
            // builder.Services.AddHttpClient<IService<Subject>,Service<Subject>>
            // builder.Services.AddScoped(
            //     sp => new HttpClient {BaseAddress = new Uri("https://localhost:5001/api")});

            await builder.Build().RunAsync();
        }
    }
}