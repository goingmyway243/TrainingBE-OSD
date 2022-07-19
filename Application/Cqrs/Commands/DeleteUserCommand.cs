﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Commands
{
    class DeleteUserCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
