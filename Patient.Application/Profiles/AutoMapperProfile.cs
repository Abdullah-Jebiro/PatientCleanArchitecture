//using AutoMapper;
//using Patient.Application.Features.Patient.Commands.CreatePatient;
//using Patient.Application.Features.Patient.Commands.DeletePatient;
//using Patient.Application.Features.Patient.Commands.UpdatePatient;
//using Patient.Application.Features.Patient.Queries.GetPatientDetail;
//using Patient.Application.Features.Patient.Queries.GetPatientsList;
//using Patient.Domain;

//namespace Patient.Application.Profiles
//{
//    public class AutoMapperProfile : Profile
//    {
//        public AutoMapperProfile()
//        {
//            CreateMap<Domain.Patient, GetPatientsListViewModel>().ReverseMap();
//            CreateMap<Domain.Patient, GetPatientDetailViewModel>().ReverseMap();
//            CreateMap<Domain.Patient, CreatePatientCommand>().ReverseMap();
//            CreateMap<Domain.Patient, UpdatePatientCommand>().ReverseMap();
//            CreateMap<Domain.Patient, DeletePatientCommand>().ReverseMap();
//            CreateMap<Address, AddressDto>().ReverseMap();
       

//        }
//    }
//}
