using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Patient.Application.Interfaces;
using Patient.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        //var connectionString = configuration.GetConnectionString("DefaultConnection");


        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());


        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer("Data Source=DESKTOP-LQFS6V0\\SQLEXPRESS;Initial Catalog=PatientCleanArchitecture;Integrated Security=True;TrustServerCertificate=True"));

        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IPatientRepository, PatientRepository>();

        return services;
    }
}
