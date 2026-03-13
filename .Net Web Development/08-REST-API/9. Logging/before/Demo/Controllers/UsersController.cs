using Contracts;
using Demo.CustomAttributes;
using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        // GET: api/Users
        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAll();
        }

        [Authorize]
        // GET api/Users/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetById(id);
        }

        // POST api/Users
        [HttpPost]
        public void Post([FromBody] CreateUserRequest createUserRequest)
        {
            _userService.Add(createUserRequest);
        }

        [Authorize]
        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            _userService.Update(id, user);
        }

        [Authorize]
        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteById(id);
        }
    }
}
