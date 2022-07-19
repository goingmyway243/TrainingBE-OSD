using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cqrs.Commands.Handlers
{
    class DeleteTaskCommandHandler : IRequestHandler<DeleteUserCommand, Guid>
    {
        public DeleteTaskCommandHandler()
        {

        }

        public Task<Guid> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
