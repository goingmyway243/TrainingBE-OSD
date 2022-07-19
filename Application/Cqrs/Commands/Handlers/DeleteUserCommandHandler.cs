using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cqrs.Commands.Handlers
{
    class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Guid>
    {
        public DeleteUserCommandHandler()
        {

        }

        public Task<Guid> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
