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
    class GetProjectsByUserIdQueryHandler : IRequestHandler<GetProjectsByUserIdQuery, IEnumerable<Project>>
    {
        public GetProjectsByUserIdQueryHandler()
        {

        }

        public Task<IEnumerable<Project>> Handle(GetProjectsByUserIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
