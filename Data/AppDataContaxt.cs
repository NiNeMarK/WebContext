using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebContext.Data
{
    public class AppDataContaxt : DbContext
    {
        public AppDataContaxt() : base("name=DataContext") { }

        public DbSet<MyEntity> MyEntities { get; set; }
    }

    public class MyEntity
        {
            public int ID { get; set; }
            public int saleYear { get; set; }
            public string PolicyID { get; set; }
        }
   
}