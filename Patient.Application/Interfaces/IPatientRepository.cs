using Patient.Application.Models;

namespace Patient.Application.Interfaces
{
    public interface IPatientRepository : IAsyncRepository<Domain.Patient>
    {
        Task<PaginatedList<Domain.Patient>> GetAllPatientsAsync(bool includeAddress ,int pageNumber, int pageSize);
        Task<Domain.Patient> GetPatientByIdAsync(Guid id, bool includeAddress);
    }
}
