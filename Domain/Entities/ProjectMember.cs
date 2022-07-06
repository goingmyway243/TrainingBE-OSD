using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class ProjectMember : BaseEntity<Guid>
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

        public void Accept()
        {
            if (MemberRole == Role.Pending)
            {
                MemberRole = Role.Member;
            }
        }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
