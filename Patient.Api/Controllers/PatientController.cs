using Patient.Application.Features.Patient.Commands.CreatePatient;
using Patient.Application.Features.Patient.Commands.DeletePatient;
using Patient.Application.Features.Patient.Commands.UpdatePatient;
using Patient.Application.Features.Patient.Queries.GetPatientDetail;
using Patient.Application.Features.Patient.Queries.GetPatientsList;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Patient.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PatientController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<ActionResult<List<GetPatientsListViewModel>>> GetAllPatients()
        {
            var dtos = await _mediator.Send(new GetPatientsListQuery());
            return Ok(dtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetPatientDetailViewModel>> GetPatientById(Guid id)
        {
            var getEventDetailQuery = new GetPatientDetailQuery() { Id = id };
            return Ok(await _mediator.Send(getEventDetailQuery));
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreatePatientCommand createPatientCommand)
        {
            Guid id = await _mediator.Send(createPatientCommand);
            return Ok(id);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] UpdatePatientCommand updatePatientCommand)
        {
            await _mediator.Send(updatePatientCommand);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deletePatientCommand = new DeletePatientCommand() { Id = id };
            await _mediator.Send(deletePatientCommand);
            return NoContent();
        }

    }
}
