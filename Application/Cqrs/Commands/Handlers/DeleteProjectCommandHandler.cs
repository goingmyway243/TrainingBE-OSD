using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cqrs.Commands.Handlers
{
    class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand, Guid>
    {
        public DeleteProjectCommandHandler()
        {

        }

        public Task<Guid> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
