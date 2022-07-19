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
    public class GetAllProjectMembersQueryHandler : IRequestHandler<GetAllProjectMembersQuery, IEnumerable<ProjectMember>>
    {
        public GetAllProjectMembersQueryHandler()
        {

        }

        public Task<IEnumerable<ProjectMember>> Handle(GetAllProjectMembersQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
