using System.ComponentModel.DataAnnotations;

namespace AuthorizationDemo.Models
{
    public class HeadPrivilege
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public string IconUrl { get; set; }
        public List<Privilege> Privileges { get; set; } = new List<Privilege>();
    }
}
