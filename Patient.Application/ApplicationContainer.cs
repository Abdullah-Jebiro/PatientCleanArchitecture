using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Patient.Application;
public static class ApplicationContainer
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());
        //services.AddScoped<IEmailRepClient, EmailRepClient>();
        return services;
    }
}

