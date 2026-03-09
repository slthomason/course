using Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Demo.Test.Helper
{
    internal class DatabaseHelper
    {
        public static DataContext GetDatabase()
        {
            var _contextOptions = new DbContextOptionsBuilder<DataContext>()
          .UseInMemoryDatabase("TestDatabase")
          .ConfigureWarnings(b => b.Ignore(InMemoryEventId.TransactionIgnoredWarning))
          .Options;


            var databaseObj = new DataContext(_contextOptions);
            databaseObj.Database.EnsureDeleted();
            databaseObj.Database.EnsureCreated();

            return databaseObj;
        }
    }
}
