using Demo.Models;

namespace Demo.Services
{
    public class UserService
    {

        private readonly DataContext _dataContext;
        public UserService(DataContext dataContext)
        {
            _dataContext = dataContext;

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
            return new Models.User { };
        }

        public void Add(User user)
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

        public void Update(int id,  User user)
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

    }
}
