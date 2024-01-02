using AuthorizationDemo.Data;
using System.ComponentModel.DataAnnotations;

namespace AuthorizationDemo.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public List<AppUser> Users { get; set; } = new List<AppUser>();
        public List<RolePrivileges> RolePrivileges { get; set; } = new List<RolePrivileges>();
    }
}
