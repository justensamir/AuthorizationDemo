using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizationDemo.Models
{
    public class RolePrivileges
    {
        public int RoleId { get; set; }
        public int PrivilegeId { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
        [ForeignKey("PrivilegeId")]
        public Privilege? Privilege { get; set; }
    }
}
