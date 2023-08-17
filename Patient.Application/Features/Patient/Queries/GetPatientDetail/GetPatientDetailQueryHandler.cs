using AutoMapper;
using MediatR;
using Patient.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Application.Features.Patient.Queries.GetPatientDetail
{
    public class GetPatientDetailQueryHandler : IRequestHandler<GetPatientDetailQuery, GetPatientDetailViewModel>
    {


        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;

        public GetPatientDetailQueryHandler(IPatientRepository patientRepository , IMapper mapper)
        {
            _patientRepository = patientRepository;
            _mapper = mapper;
        }

        public async Task<GetPatientDetailViewModel> Handle(GetPatientDetailQuery request, CancellationToken cancellationToken)
        {
            var patient = await _patientRepository.GetPatientByIdAsync(request.Id,true);
            return _mapper.Map<GetPatientDetailViewModel>(patient);
        }
    }
}
