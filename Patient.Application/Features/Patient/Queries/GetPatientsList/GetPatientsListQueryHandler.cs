using AutoMapper;
using MediatR;
using Patient.Application.Interfaces;

namespace Patient.Application.Features.Patient.Queries.GetPatientsList
{

    public class GetPatientsListQueryHandler : IRequestHandler<GetPatientsListQuery, List<GetPatientsListViewModel>>
    {
        private readonly IPatientRepository _PatientRepository;
        private readonly IMapper _mapper;

        public GetPatientsListQueryHandler(IPatientRepository PatientRepository, IMapper mapper)
        {
            _PatientRepository = PatientRepository;
            _mapper = mapper;
        }
        public async Task<List<GetPatientsListViewModel>> Handle(GetPatientsListQuery request, CancellationToken cancellationToken)
        {
            var allPatients = await _PatientRepository.GetAllPatientsAsync(true);
            return _mapper.Map<List<GetPatientsListViewModel>>(allPatients);
        }
    }
}
