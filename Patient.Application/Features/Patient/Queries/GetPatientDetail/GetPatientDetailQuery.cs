using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Application.Features.Patient.Queries.GetPatientDetail
{
    public class GetPatientDetailQuery:IRequest<GetPatientDetailViewModel>
    {
        public Guid Id { get; set; }

    }
}
