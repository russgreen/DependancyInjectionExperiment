using DemoLibrary.DataAccess;
using DemoLibrary.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DemoLibrary.Extensions;

public static class DependancyInjectionExtensions
{
    public static IServiceCollection AddDemoServices(this IServiceCollection services, string connectionString)
    {
        services
            .AddSingleton<IDataConnection>(x => new SQLConnection(connectionString))
            .AddSingleton<ISettings, Settings>()
            .AddTransient<IMessages, Messages>();

        return services;
    }
}
