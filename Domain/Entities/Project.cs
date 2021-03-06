using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Project : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ProjectMember> ProjectMembers { get; set; }
        public List<Task> Tasks { get; set; }

        public override ValidationResult Validate()
        {
            if(string.IsNullOrEmpty(Name))
            {
                return new ValidationResult("Name cannot be empty");
            }

            return ValidationResult.Success;
        }
    }
}
