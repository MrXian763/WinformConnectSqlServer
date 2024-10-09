using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformConnectSqlServer
{
    class MyDBContext : DbContext
    {
        public MyDBContext() : base("Server=localhost;uid=sa;pwd=12345678;Database=TestDBForWinform;Trusted_Connection=false;")
        {

        }

        public DbSet<UserTModel> UserTForWinform { get; set; }
    }
}
