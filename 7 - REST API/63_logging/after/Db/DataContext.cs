using Entities;
using Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Db
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        void IDataContext.Remove<T>(T entity)
        {
            Remove(entity);
        }

        void IDataContext.SaveChanges()
        {
            SaveChanges();
        }

        void IDataContext.Update<T>(T entity)
        {
            Update(entity);
        }
    }
}
