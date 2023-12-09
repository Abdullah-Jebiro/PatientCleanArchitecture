using Microsoft.EntityFrameworkCore;
using Patient.Domain;

namespace Patient.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Domain.Patient> Patients { get; set; }
        public DbSet<Address> Addresses { get; set; }

    }

}
