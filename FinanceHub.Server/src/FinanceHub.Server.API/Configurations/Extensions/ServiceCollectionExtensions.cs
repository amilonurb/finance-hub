using FinanceHub.Server.API.Configurations.Options;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceHub.Server.API.Configurations.Extensions
{
    public static class ServiceCollectionExtensions
    {
        internal static IServiceCollection AddMyControllers(this IServiceCollection services)
        {
            services.AddControllers();
            return services;
        }

        internal static IServiceCollection AddMySwaggerGen(this IServiceCollection services) =>
            services.AddSwaggerGen(SwaggerGenOptionsFactory.Create());
    }
}