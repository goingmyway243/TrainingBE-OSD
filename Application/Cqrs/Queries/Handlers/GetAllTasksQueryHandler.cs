using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cqrs.Queries.Handlers
{
    public class GetAllTasksQueryHandler : IRequestHandler<GetAllTasksQuery, IEnumerable<Domain.Entities.Task>>
    {
        public GetAllTasksQueryHandler()
        {

        }

        public Task<IEnumerable<Domain.Entities.Task>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
