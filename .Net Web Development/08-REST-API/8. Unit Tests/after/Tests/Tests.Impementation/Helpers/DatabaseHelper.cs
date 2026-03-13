using Db;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Impementation.Helpers
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
