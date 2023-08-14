using MediatR;

namespace Patient.Application.Features.Patient.Queries.GetPatientsList
{
    public class GetPatientsListQuery : IRequest<List<GetPatientsListViewModel>>
    {

    }
}
