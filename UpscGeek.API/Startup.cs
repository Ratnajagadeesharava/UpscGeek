using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using UpscGeek.Core.Entities;
using UpscGeek.Core.Repositories;
using UpscGeek.Core.Repositories.Base;
using UpscGeek.Infrastructure.Data;
using UpscGeek.Infrastructure.Repositories;
using UpscGeek.Infrastructure.Repositories.Base;

namespace UpscGeek.API
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
            services.AddControllers();
            services.AddDbContext<MainDbContext>(options=>
                options.UseNpgsql(Configuration.GetConnectionString("APIConnection"),m=>m.MigrationsAssembly("UpscGeek.API"))
                
                );
            services.AddCors(options =>
                options.AddDefaultPolicy(
                    builder => builder.WithOrigins("https://localhost:5005")));
            services.AddTransient<IRepository<Subject>, SubjectRepository>();
            // services.AddCors(policy=>policy.)
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo {Title = "UpscGeek.API", Version = "v1"});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "UpscGeek.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}