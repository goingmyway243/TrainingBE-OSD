using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cqrs.Commands.Handlers
{
    class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Guid>
    {
        public UpdateProjectCommandHandler()
        {

        }

        public Task<Guid> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
