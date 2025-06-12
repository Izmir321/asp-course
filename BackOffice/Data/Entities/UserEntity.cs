using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata;

namespace Data.Entities
{
    public class UserEntity : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LasttName { get; set; }
        public string? JobTitle { get; set; }

        public virtual ICollection<ProjectEntity> Projects { get; set; } = [];


    }
}
