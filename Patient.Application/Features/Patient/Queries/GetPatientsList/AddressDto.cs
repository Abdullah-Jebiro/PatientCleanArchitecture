namespace Patient.Application.Features.Patient.Queries.GetPatientsList
{
    public class AddressDto
    {
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }

    }
}
