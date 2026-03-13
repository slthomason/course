using Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        // GET: api/Users
        [HttpGet]
        public List<User> Get()
        {
            // creating users empty list
            List<User> users = new List<User>();

            // adding user to users list
            users.Add(new Models.User()
            {
                Id = 1,
                FirstName = "Spencer",
                LastName = "Thomson"
            });
            users.Add(new Models.User()
            {
                Id = 1,
                FirstName = "Matthew",
                LastName = "Thomson"
            });


            return users;
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return new Models.User()
            {
                Id = 1,
                FirstName = "Spencer",
                LastName = "Thomson"
            };
        }

        // POST api/Users
        [HttpPost]
        public void Post([FromBody] User user)
        {
            // logic to add users to list
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {

            // logic to update existing user in the list
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // logic to delete the  existing user from the list
        }
    }
}
