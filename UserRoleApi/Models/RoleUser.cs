using System.ComponentModel.DataAnnotations;

namespace UserRoleApi.Models
{
    public class RoleUser
    {
        [Key]
        public Guid Id { get; set; }
        public User User { get; set; }

        [Key]
        public Guid Id { get; set; }
        public Role Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
