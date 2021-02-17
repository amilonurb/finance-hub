using FinanceHub.Server.Core;
using FinanceHub.Server.Data;
using FinanceHub.Server.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceHub.Server.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMyDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCore(configuration);
            services.AddData(configuration);
            services.AddServices(configuration);
            return services;
        }
    }
}