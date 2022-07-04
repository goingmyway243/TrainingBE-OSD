using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Task : BaseEntity<Guid>
    {
        public enum StatusType
        {
            New,
            Inprogress,
            Finished
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public StatusType Status { get; set; }
        public Guid ProjectId { get; set; }
        public Guid AssignedUserId { get; private set; }

        public Project Project { get; set; }
        public User AssignedUser{ get; private set; }

        public void Assign(User userToAssign)
        {
            if(Status == StatusType.Finished)
            {
                throw new Exception("The task cannot be assigned to others members when it's Finished");
            }

            AssignedUserId = userToAssign.Id;
            AssignedUser = userToAssign;
        }
    }
}
