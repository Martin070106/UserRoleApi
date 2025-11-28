using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRoleApi.Models;
using UserRoleApi.Models.Dtos;

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
        public async Task<ActionResult> AddNewRoleToUser(AddNewSwitchDto roleUser)
        {

            var roleuser = new RoleUser
            {

                RoleId = roleUser.RolesId,
                UserId = roleUser.UsersId

            };

            await _context.roleuser.AddAsync(roleuser);
            await _context.SaveChangesAsync();
            return Ok(roleuser);

        }
    }
}
