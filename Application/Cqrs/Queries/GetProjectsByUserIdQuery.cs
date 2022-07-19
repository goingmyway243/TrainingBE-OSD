using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Queries
{
    class GetProjectsByUserIdQuery : IRequest<IEnumerable<Project>>
    {
        public Guid UserId { get; set; }
    }
}
