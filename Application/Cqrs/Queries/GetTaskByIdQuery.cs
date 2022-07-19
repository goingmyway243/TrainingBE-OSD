﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Queries
{
    public class GetTaskByIdQuery : IRequest<Domain.Entities.Task>
    {
        public Guid Id { get; set; }
    }
}
