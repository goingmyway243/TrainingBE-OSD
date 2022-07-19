using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cqrs.Queries.Handlers
{
    public class GetProjectMemberByIdQueryHandler : IRequestHandler<GetProjectMemberByIdQuery, ProjectMember>
    {
        public GetProjectMemberByIdQueryHandler()
        {

        }

        public Task<ProjectMember> Handle(GetProjectMemberByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
