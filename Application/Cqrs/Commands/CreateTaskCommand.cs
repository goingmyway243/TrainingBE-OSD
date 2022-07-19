using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Commands
{
    class CreateTaskCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Domain.Entities.Task.StatusType Status { get; set; }
        public Guid ProjectId { get; set; }
        public Guid? AssignedUserId { get; private set; }
    }
}
