namespace Patient.Application.Features.Patient.Queries.GetPatientsList
{
    public class GetPatientsListViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = null!;
        public int FileNo { get; set; }
        public string ContactPhone { get; set; } = null!;
        public DateTime FirstVisitDate { get; set; }
        public AddressDto? Address { get; set; }
    }
}
