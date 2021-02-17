using FinanceHub.Server.API.Configurations.Extensions;
using FinanceHub.Server.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceHub.Server.API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration) => _configuration = configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // CORS

            // REQUEST LOCALIZATION

            services.AddMyControllers();

            services.AddMySwaggerGen();

            services.AddMyDependencies(_configuration);

            // RESPONSE COMPRESSION

            // AUTHORIZATION
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMyExceptionHandler(env);

            // CORS

            // HSTS

            app.UseHttpsRedirection();

            // AUTHENTICATION

            app.UseRouting();

            app.UseAuthorization();

            app.UseMySwagger();

            // REQUEST LOCALIZATION

            app.UseMyEndpoints();

            // RESPONSE COMPRESSION
        }
    }
}