using Microsoft.EntityFrameworkCore;
using Patient.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patient.Persistence
{
    public class PatientRepository : BaseRepository<Domain.Patient>, IPatientRepository
    {
        public PatientRepository(PatientDbContext patientDbContext): base(patientDbContext)
        {

        }
        public async Task<IReadOnlyList<Domain.Patient>> GetAllPatientsAsync(bool includeCategory)
        {
            List<Domain.Patient> allPatients = new List<Domain.Patient>();
            allPatients = includeCategory ?
                  await _dbContext.Patients.Include(x => x.Address).ToListAsync() :
                  await _dbContext.Patients.ToListAsync();

            if (!allPatients.Any())
            {
                throw new Exception();
            }
            return allPatients;
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
