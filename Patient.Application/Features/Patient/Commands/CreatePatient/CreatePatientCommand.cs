using MediatR;
using Patient.Application.Attributes;
using Patient.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Application.Features.Patient.Commands.CreatePatient
{
    public class CreatePatientCommand:IRequest<Guid>
    {
        public string Name { get; set; } = null!;
        public int FileNo { get; set; }
        public string CitizenId { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public string Nationality { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        [EmailAddress]
        [ReputableEmail]
        public string Email { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string ContactRelation { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public DateTime FirstVisitDate { get; set; }
        public DateTime RecordCreationDate { get; set; } = DateTime.UtcNow;
    }
}
