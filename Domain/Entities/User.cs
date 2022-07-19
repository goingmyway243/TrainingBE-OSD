using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : BaseEntity<Guid>
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public List<ProjectMember> ProjectMembers { get; set; }
        public List<Task> AssignedTasks { get; set; }

        public bool Login(string email, string password)
        {
            return Email == email && Password == password;
        }

        public override ValidationResult Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                return new ValidationResult("Email cannot be empty");
            }

            if (string.IsNullOrEmpty(Password))
            {
                return new ValidationResult("Password cannot be empty");
            }

            return ValidationResult.Success;
        }
    }
}
