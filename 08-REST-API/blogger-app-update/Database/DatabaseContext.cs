using BloggerApp.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace BloggerApp.Database;

public class DatabaseContext : DbContext
{
    public DbSet<Users> users {get;set;}
    public DatabaseContext(DbContextOptions options) :base (options){}
}
