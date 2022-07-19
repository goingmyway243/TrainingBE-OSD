using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cqrs.Commands.Handlers
{
    class DeleteProjectMemberCommandHandler : IRequestHandler<DeleteProjectCommand, Guid>
    {
        public DeleteProjectMemberCommandHandler()
        {

        }

        public Task<Guid> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
