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
        public Guid? AssignedUserId { get; private set; }

        public Project Project { get; set; }
        public User AssignedUser { get; private set; }

        public User GetProjectOwner()
        {
            return Project
                .ProjectMembers
                .FirstOrDefault(member => member.MemberRole == ProjectMember.Role.Owner)
                .User;
        }

        public void Assign(User userToAssign)
        {
            if (AssignedUserId != null && AssignedUserId != GetProjectOwner().Id)
            {
                throw new Exception("Project member cannot assign to assigned tasks in the project");
            }

            if (Status == StatusType.Finished)
            {
                throw new Exception("The task cannot be assigned to others members when it's Finished");
            }

            SetAssignedUser(userToAssign);
        }

        private void SetAssignedUser(User userToAssign)
        {
            AssignedUser = userToAssign;
            AssignedUserId = AssignedUser.Id;
        }

        public override void Validate()
        {
            if(Name == null || Name == "")
            {
                throw new Exception("Name cannot be empty");
            }
        }
    }
}
