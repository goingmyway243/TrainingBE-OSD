using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Queries
{
    public class GetAllTasksQuery : IRequest<IEnumerable<Domain.Entities.Task>>
    {
    }
}
