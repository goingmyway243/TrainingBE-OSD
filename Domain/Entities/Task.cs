using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Task : BaseEntity<Guid>
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

        public void UpdateStatus(StatusType status, User auditUser)
        {
            if(auditUser.Id != AssignedUserId)
            {
                throw new Exception("Only the task assignee can update task status");
            }

            Status = status;
        }

        public override ValidationResult Validate()
        {
            if(string.IsNullOrEmpty(Name))
            {
                return new ValidationResult("Name cannot be empty");
            }

            return ValidationResult.Success;
        }

        private void SetAssignedUser(User userToAssign)
        {
            AssignedUser = userToAssign;
            AssignedUserId = AssignedUser.Id;
        }
    }
}
