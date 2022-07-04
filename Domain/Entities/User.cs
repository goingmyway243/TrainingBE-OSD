using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class User : BaseEntity<Guid>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public List<ProjectMember> ProjectMembers { get; set; }
        public List<Task> AssignedTasks { get; set; }
    }
}
