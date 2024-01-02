using AuthorizationDemo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthorizationDemo.Data
{
    public class CloudDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<Privilege> Privileges { get; set; }
        public DbSet<RolePrivileges> RolePrivileges { get; set; }
        public DbSet<HeadPrivilege> HeadPrivileges { get; set; }

        public CloudDbContext(DbContextOptions<CloudDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RolePrivileges>().HasKey(e => new { e.RoleId, e.PrivilegeId });
            base.OnModelCreating(builder);
        }
    }
}
