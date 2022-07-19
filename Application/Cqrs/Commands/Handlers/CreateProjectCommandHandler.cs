using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cqrs.Commands.Handlers
{
    class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, Guid>
    {
        public CreateProjectCommandHandler()
        {

        }

        public Task<Guid> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
