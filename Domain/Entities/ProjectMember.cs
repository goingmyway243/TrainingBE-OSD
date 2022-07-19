using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProjectMember : BaseEntity<Guid>
    {
        public enum Role
        {
            Owner,
            Member,
            Rejected,
            Pending
        }

        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public Role MemberRole { get; set; }
        public User User { get; set; }
        public Project Project { get; set; }

        public void Reply(bool isAccepted)
        {
            if (MemberRole == Role.Pending)
            {
                MemberRole = isAccepted ? Role.Member : Role.Rejected;
            }
        }

        public override ValidationResult Validate()
        {
            return ValidationResult.Success;
        }
    }
}
