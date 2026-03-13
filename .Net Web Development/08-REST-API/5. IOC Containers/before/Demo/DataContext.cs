using Demo.Models;
using Microsoft.EntityFrameworkCore;
namespace Demo
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
