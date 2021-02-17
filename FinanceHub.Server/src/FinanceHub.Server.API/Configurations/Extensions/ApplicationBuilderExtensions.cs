using FinanceHub.Server.API.Configurations.Options;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace FinanceHub.Server.API.Configurations.Extensions
{
    internal static class ApplicationBuilderExtensions
    {
        internal static IApplicationBuilder UseMyExceptionHandler(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            if (env.IsStaging() || env.IsProduction())
            {
                app.UseExceptionHandler(ExceptionHandlerOptionsFactory.Create());
            }

            return app;
        }

        internal static IApplicationBuilder UseMySwagger(this IApplicationBuilder app) =>
            app.UseSwagger().UseSwaggerUI(SwaggerUIOptionsFactory.Create());

        internal static IApplicationBuilder UseMyEndpoints(this IApplicationBuilder app) =>
            app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}