using Contracts;
using Demo.CustomAttributes;
using Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ILogger _logger;
        public UsersController(IUserService userService, ILogger<UsersController> logger)
        {
            _userService = userService;
            _logger = logger;

        }

        [Authorize]
        // GET: api/Users
        [HttpGet]
        public List<User>? Get()
        {
            try
            {
                _logger.LogInformation("Get action called");
                return _userService.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");
            }
            return null;

        }

        [Authorize]
        // GET api/Users/5
        [HttpGet("{id}")]
        public User? Get(int id)
        {
            try
            {
                _logger.LogInformation($"Get action called with ${id}");

                return _userService.GetById(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");
            }

            return null;
           
        }

        // POST api/Users
        [HttpPost]
        public void Post([FromBody] CreateUserRequest createUserRequest)
        {
            try
            {
                _logger.LogInformation($"Post action called with first Name: {0} and last Name : {1}", createUserRequest.FirstName,createUserRequest.LastName);
                _userService.Add(createUserRequest);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");
            }
          
        }

        [Authorize]
        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            try
            {
                _logger.LogDebug("Put action called");
                _userService.Update(id, user);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Unhandled exception");
            }
           
        }

        [Authorize]
        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            try
            {
                _userService.DeleteById(id);

            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Unhandled exception");
            }
        }
    }
}
