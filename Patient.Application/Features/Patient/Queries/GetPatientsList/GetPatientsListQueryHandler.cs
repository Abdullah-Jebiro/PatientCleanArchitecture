using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Patient.Application.Interfaces;
using Patient.Application.Mappings;
using Patient.Application.Models;

namespace Patient.Application.Features.Patient.Queries.GetPatientsList
{



    public class GetPatientsListQueryHandler : IRequestHandler<GetPatientsListQuery, PaginatedList<GetPatientsListViewModel>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPatientsListQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PaginatedList<GetPatientsListViewModel>> Handle(GetPatientsListQuery request, CancellationToken cancellationToken)
        {
            IQueryable<Domain.Patient> allPatients;
            allPatients = 
                   _context.Patients;

            return await allPatients
                .OrderBy(x => x.Name)
                .ProjectTo<GetPatientsListViewModel>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.PageNumber, request.PageSize);

       
         
        }
    }
}
