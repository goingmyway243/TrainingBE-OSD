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
        public Guid UserId { get; set; }
        public Guid ProjectId { get; set; }
        public bool IsOwner { get; set; }
        public bool IsAccepted { get; set; }

        public User User { get; set; }
        public Project Project { get; set; }
    }
}
