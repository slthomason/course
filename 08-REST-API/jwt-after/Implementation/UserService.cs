using Contracts;
using Entities;
using Interfaces;
using Microsoft.Extensions.Options;
using Shared;
using System.Text;

namespace Implementation
{
    public class UserService : IUserService
    {

        private readonly IDataContext _dataContext;
        private readonly IJwtService _jwtService;

        public UserService(IDataContext dataContext, IJwtService jwtService)
        {
            _dataContext = dataContext;
            _jwtService = jwtService;
        }

        public List<User> GetAll()
        {
            return _dataContext.Users.ToList();
        }

        public User GetById(int id)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.Id == id);
            if (user != null)
                return user;

            // if user not found returning empty user
            return new User { };
        }

        public void Add(CreateUserRequest createUserRequest)
        {
            // adding user

            if (createUserRequest != null)
            {
                var newUser = new User
                {
                    FirstName = createUserRequest.FirstName,
                    LastName = createUserRequest.LastName,
                    Username = createUserRequest.Username,
                    Password = createUserRequest.Password
                };
                _dataContext.Users.Add(newUser);
                _dataContext.SaveChanges();
            }
        }

        public void Update(int id, User user)
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

        public void DeleteById(int id)
        {
            var dbUser = _dataContext.Users.FirstOrDefault(x => x.Id == id);
            if (dbUser != null)
            {
                _dataContext.Remove(dbUser);
                _dataContext.SaveChanges();
            }

        }

        public AuthenticateResponse Authenticate(string userName, string password)
        {
            var user = _dataContext.Users.SingleOrDefault(x => x.Username == userName && x.Password == password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = _jwtService.GenerateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }


    }
}
