using Microsoft.Extensions.DependencyInjection;
using MoneyMaster.Application;
using MoneyMaster.Infrastructure;

namespace MoneyMaster.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAllServices(this IServiceCollection services)
            => services
                .AddApplicationServices()
                .AddInfrastructureServices();
    }
}