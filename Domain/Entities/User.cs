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

        public bool Login(string email, string password)
        {
            return Email == email && Password == password;
        }

        public override void Validate()
        {
            if (Email == null || Email == "")
            {
                throw new Exception("Email cannot be empty");
            }

            if (Password == null || Password == "")
            {
                throw new Exception("Password cannot be empty");
            }
        }
    }
}
