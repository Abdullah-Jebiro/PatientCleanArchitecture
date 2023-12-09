using MediatR;
using Patient.Application.Features.Patient.Commands.DeletePatient;
using Patient.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Application.Features.Patient.Commands.UpdatePatient
{
    public class UpdatePatientCommandHandler : IRequestHandler<UpdatePatientCommand>
    {
        private readonly IPatientRepository _PatientRepository;
        public UpdatePatientCommandHandler(IPatientRepository PatientRepository)
        {
            _PatientRepository = PatientRepository;
        }

        public async Task<Unit> Handle(UpdatePatientCommand request, CancellationToken cancellationToken)
        {
            var Patient = await _PatientRepository.GetByIdAsync(request.Id);

            //TODO

            await _PatientRepository.UpdateAsync(Patient);

            return Unit.Value;
        }
    }
}
