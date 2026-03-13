using Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public UsersController(DataContext dataContext)
        {
            _dataContext = dataContext;

        }

        // GET: api/Users
        [HttpGet]
        public List<User> Get()
        {
            return _dataContext.Users.ToList();
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
                return user;

            // if user not found returning empty user
            return new Models.User { };
        }

        // POST api/Users
        [HttpPost]
        public void Post([FromBody] User user)
        {
            // adding user

            if (user != null)
            {
                var newUser = new Models.User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName
                };
                _dataContext.Users.Add(newUser);
                _dataContext.SaveChanges();
            }
        }

        // PUT api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            if (user != null)
            {
                var dbUser = _dataContext.Users.FirstOrDefault(x => x.Id == id);
                if (dbUser != null)
                {
                    dbUser.FirstName = user.FirstName;
                    dbUser.LastName = user.LastName;
                    _dataContext.Update(dbUser);
                    _dataContext.SaveChanges();
                }
            }
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

            var dbUser = _dataContext.Users.FirstOrDefault(x => x.Id == id);
            if (dbUser != null)
            {
                _dataContext.Remove(dbUser);
                _dataContext.SaveChanges();
            }

        }
    }
}
