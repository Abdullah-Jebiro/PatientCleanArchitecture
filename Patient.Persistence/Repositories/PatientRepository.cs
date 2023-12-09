using Microsoft.EntityFrameworkCore;
using Patient.Application.Interfaces;
using Patient.Application.Mappings;
using Patient.Application.Models;
using Patient.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patient.Persistence
{
    public class PatientRepository : BaseRepository<Domain.Patient>, IPatientRepository
    {


        public PatientRepository(ApplicationDbContext patientDbContext): base(patientDbContext)
        {

        }
        public async Task<PaginatedList<Domain.Patient>> GetAllPatientsAsync(bool includeCategory ,int pageNumber , int pageSize)
        {
            IQueryable<Domain.Patient> allPatients;
            allPatients = includeCategory ?
                   _dbContext.Patients.Include(x => x.Address) :
                   _dbContext.Patients;

          

            if (!allPatients.Any())
            {
                throw new Exception();
            }

            return await PaginatedList<Domain.Patient>.CreateAsync(allPatients, pageNumber, pageSize);
        }

        public async Task<Domain.Patient> GetPatientByIdAsync(Guid id, bool includeCategory)
        {
            Domain.Patient? Patient = new Domain.Patient();
            Patient = includeCategory ?
                await _dbContext.Patients.Include(x => x.Address).FirstOrDefaultAsync(x => x.PatientId == id) : 
                await GetByIdAsync(id);

            if (Patient == null)
            {
                throw new Exception();
            }

            return Patient;
        }
    }

}
