using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRoleApi.Models;

namespace UserRoleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleUserController : ControllerBase
    {
        private readonly UserRoleDbContext _context;
        public RoleUserController(UserRoleDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<ActionResult> AddNewRoleToUser(RoleUser roleUser)
        {
            try
            {
                var roleUser = new RoleUser
                {
                    UserId = roleUser.UserId,
                    RoleId = roleUser.RoleId,
                };
                await _context.SaveChangesAsync();
                return Ok(roleUser);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
