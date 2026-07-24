using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PolePicker.Infrastructure.Options;
using PolePicker.Infrastructure.Persistence;

namespace PolePicker.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<ConnectionStringsOptions>(configuration.GetSection("ConnectionStrings"));

        serviceCollection.AddDbContext<AppDbContext>();
    }
}