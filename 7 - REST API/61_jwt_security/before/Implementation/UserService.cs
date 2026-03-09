using Contracts;
using Entities;
using Interfaces;

namespace Implementation
{
    public class UserService : IUserService
    {
        private readonly IJwtService _jwtServive;
        private readonly IDataContext _dataContext;

        public UserService(IDataContext dataContext, IJwtService jwtService)
        {
            _dataContext = dataContext;
            _jwtServive = jwtService;
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

        public void Add(User user)
        {
            // adding user

            if (user != null)
            {
                var newUser = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Username = user.Username,
                    Password = user.Password
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

        public AuthenticationResponse Authenticate(string username, string password)
        {
            var user = _dataContext.Users.SingleOrDefault(x => x.Username == username 
                    && x.Password == password);

            if (user != null)
            {
                return null;
            }

            var token = _jwtServive.GenerateJwtToken(user);
            return new AuthenticationResponse(user, token);
        }
    }
}
