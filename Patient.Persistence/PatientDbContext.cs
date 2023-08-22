using Microsoft.EntityFrameworkCore;
using Patient.Domain;
using System;

namespace Patient.Persistence
{
    public class PatientDbContext : DbContext
    {
        public PatientDbContext(DbContextOptions<PatientDbContext> options)
            : base(options) { }

        public DbSet<Domain.Patient> Patients { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Domain.Patient>().Property(p => p.PatientId).HasDefaultValueSql("NEWID()");
            builder.Entity<Address>()
                .HasOne(p => p.Patient)
                .WithOne(a => a.Address)
                .HasForeignKey<Domain.Patient>();

            builder.Entity<Address>().HasData(AddAddress());
            builder.Entity<Domain.Patient>().HasData(AddPatients());
        }

        private Address AddAddress()
        {
            return new Address
            {
                AddressId = new Guid("DFE2516E-37A7-4B5C-AC37-EBC58F5E0A42"),
                Country = "United States",
                City = "New York",
                Street = "123 Main Street",
                Address1 = "Apartment 4A",
                Address2 = "Building XYZ"
            };
        }

        private List<Domain.Patient> AddPatients()
        {
            var address = new Address
            {
                AddressId = new Guid("DFE2516E-37A7-4B5C-AC37-EBC58F5E0A42"),
                Country = "United States",
                City = "New York",
                Street = "123 Main Street",
                Address1 = "Apartment 4A",
                Address2 = "Building XYZ"
            };

            var patients = new List<Domain.Patient>
            {
                new Domain.Patient
                {
                    PatientId = Guid.NewGuid(),
                    Name = "John Doe",
                    FileNo = 1001,
                    CitizenId = "123456789",
                    BirthDate = new DateTime(1985, 5, 10),
                    Gender = 0, // 0 for Male, 1 for Female
                    Nationality = "USA",
                    PhoneNumber = "123-456-7890",
                    Email = "john.doe@example.com",
                    AddressId =address.AddressId,
                    ContactPerson = "Jane Smith",
                    ContactRelation = "Spouse",
                    ContactPhone = "987-654-3210",
                    FirstVisitDate = new DateTime(2022, 3, 15),
                    RecordCreationDate = DateTime.Now
                },
            };

            return patients;
        }
    }
}
