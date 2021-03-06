using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Queries
{
    public class GetProjectMemberByIdQuery : IRequest<ProjectMember>
    {
        public Guid Id { get; set; }
    }
}
