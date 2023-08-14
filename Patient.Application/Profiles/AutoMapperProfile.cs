using AutoMapper;
using Patient.Application.Features.Patient.Queries.GetPatientsList;


namespace Patient.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Domain.Patient, GetPatientsListViewModel>().ReverseMap();
         
        }
    }
}
