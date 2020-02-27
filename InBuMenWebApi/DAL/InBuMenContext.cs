using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using InBuMenModels.Classes;

namespace InBuMenWebApi.DAL
{
    public class InBuMenContext : DbContext
    {
       
            public InBuMenContext() : base("InBuMenContext")
            {
            }

            public InBuMenContext(DbConnection dbConnection, bool contextOwnsConnection) : base(dbConnection,
                contextOwnsConnection)
            {

            }

            public DbSet<Rate> Rates { get; set; }
            public DbSet<Transaction> Transactions { get; set; }





            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            }
        
    }
}