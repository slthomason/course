using Entities;

namespace Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        void Add(User user);
        void Update(int id, User user);

        void DeleteById(int id);
    }
}
