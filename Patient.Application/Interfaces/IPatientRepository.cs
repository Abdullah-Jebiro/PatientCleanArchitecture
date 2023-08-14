namespace Patient.Application.Interfaces
{
    public interface IPatientRepository : IAsyncRepository<Domain.Patient>
    {
        Task<IReadOnlyList<Domain.Patient>> GetAllPatientsAsync(bool includeAddress);
        Task<Domain.Patient> GetPatientByIdAsync(Guid id, bool includeAddress);
    }
}
