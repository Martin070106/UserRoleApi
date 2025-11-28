using Microsoft.EntityFrameworkCore;

namespace UserRoleApi.Models
{
    public class UserRoleDbContext : DbContext
    {
        public UserRoleDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }

        public DbSet<RoleUser> roleuser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost; database=userroles; user=root; password=");
        }
    }
}
