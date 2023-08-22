using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Patient.Persistence;
using Patient.Application.Interfaces;

namespace Patient.Persistence
{
    public static class PersistenceContainer
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            //TODO 1
            services.AddDbContext<PatientDbContext>(options =>
                options.UseSqlServer("Data Source=DESKTOP-LQFS6V0\\SQLEXPRESS;Initial Catalog=PatientCleanArchitectureTest;Integrated Security=True;TrustServerCertificate=True"));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IPatientRepository, PatientRepository>();

            return services;
        }
    }

}
