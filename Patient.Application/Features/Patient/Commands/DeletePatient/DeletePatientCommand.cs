﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient.Application.Features.Patient.Commands.DeletePatient
{
    public class DeletePatientCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
