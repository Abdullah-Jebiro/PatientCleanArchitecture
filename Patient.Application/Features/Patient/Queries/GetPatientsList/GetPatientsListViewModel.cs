using AutoMapper;
using Patient.Application.Features.Patient.Queries.GetPatientDetail;

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

        private class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<Domain.Address, AddressDto>();
                CreateMap<Domain.Patient, GetPatientsListViewModel>()
                    .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
            }
        }
    }
}
