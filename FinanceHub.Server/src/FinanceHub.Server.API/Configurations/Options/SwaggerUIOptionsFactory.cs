using Microsoft.AspNetCore.Builder;
using Swashbuckle.AspNetCore.SwaggerUI;
using System;

namespace FinanceHub.Server.API.Configurations.Options
{
    internal static class SwaggerUIOptionsFactory
    {
        internal static Action<SwaggerUIOptions> Create()
        {
            return options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "FinanceHub.Server.API v1");
            };
        }
    }
}