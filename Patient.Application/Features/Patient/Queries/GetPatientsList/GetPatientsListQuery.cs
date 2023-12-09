using MediatR;
using Patient.Application.Models;

namespace Patient.Application.Features.Patient.Queries.GetPatientsList
{
    public class GetPatientsListQuery : IRequest<PaginatedList<Domain.Patient>>
    {
       public bool includeAddress { get; set; }
       public int PageNumber { get; init; } = 1;
       public int PageSize { get; init; } = 10;
    }



}
