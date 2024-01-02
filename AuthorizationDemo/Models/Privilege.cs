using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizationDemo.Models
{
    public class Privilege
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string IconUrl { get; set; }
        public string Url { get; set; }
        public int? HeadPrivilegeId { get; set; }
        [ForeignKey("HeadPrivilegeId")]
        public HeadPrivilege? HeadPrivilege { get; set; }
        public List<RolePrivileges> RolePrivileges { get; set; } = new List<RolePrivileges>();
    }
}
