using BloggerApp.Application.Interface;
using BloggerApp.Database;
using BloggerApp.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService _userService)
        {
            this._userService = _userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> registerUser(Register register)
        {
            return Ok(await _userService.registerUser(register).ConfigureAwait(false));
        }
    }
}
