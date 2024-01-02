using AuthorizationDemo.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuthorizationDemo.Data
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; } = null!;
        public int? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role? Role { get; set; }
    }
}
