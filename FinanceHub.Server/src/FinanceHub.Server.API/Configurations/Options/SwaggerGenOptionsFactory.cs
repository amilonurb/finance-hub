using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;

namespace FinanceHub.Server.API.Configurations.Options
{
    internal class SwaggerGenOptionsFactory
    {
        internal static Action<SwaggerGenOptions> Create()
        {
            var apiInfo = new OpenApiInfo
            {
                Title = "FinanceHub.Server.API",
                Version = "v1"
            };

            return options =>
            {
                options.SwaggerDoc("v1", apiInfo);
            };
        }
    }
}