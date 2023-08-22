using AutoMapper;
using MediatR;
using Patient.Application.Interfaces;

namespace Patient.Application.Features.Patient.Commands.CreatePatient
{
    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly IPatientRepository _patientRepository;

        public CreatePatientCommandHandler(IMapper mapper, IPatientRepository patientRepository)
        {
            _mapper = mapper;
            _patientRepository = patientRepository;
        }
        public async Task<Guid> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            Domain.Patient patient = _mapper.Map<Domain.Patient>(request);

            CreateCommandValidator validator = new CreateCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("patient is not valid");
            }

            patient = await _patientRepository.AddAsync(patient);

            return patient.PatientId;


        }
    }
}