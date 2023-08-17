using MediatR;
using Patient.Application.Interfaces;


namespace Patient.Application.Features.Patient.Commands.DeletePatient
{
    public class DeletePatientCommandHandler : IRequestHandler<DeletePatientCommand>
    {
        private readonly IPatientRepository _PatientRepository;
        public DeletePatientCommandHandler(IPatientRepository PatientRepository)
        {
            _PatientRepository = PatientRepository;
        }

        public async Task<Unit> Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            var Patient = await _PatientRepository.GetByIdAsync(request.Id);

            await _PatientRepository.DeleteAsync(Patient);

            return Unit.Value;
        }
    }

}
