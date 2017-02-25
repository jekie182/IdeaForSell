using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCore.Models.BaseSQL
{
    internal class DBContext: DbContext
    {
        public DBContext() : base("DBConnectionString")
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");

            Database.SetInitializer(new CreateDatabaseIfNotExists<DBContext>());
        }
    }
}
