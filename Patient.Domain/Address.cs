namespace Patient.Domain
{
    public class Address
    {
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }

        public Patient Patient { get; set; } = null!;
    }
}