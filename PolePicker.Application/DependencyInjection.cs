using Microsoft.Extensions.DependencyInjection;
using PolePicker.Application.Services;
using PolePicker.Application.Services.Interfaces;

namespace PolePicker.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddStabilimentumApplication(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        
        services.AddScoped<IGroupService, GroupService>();

        return services;
    }
}