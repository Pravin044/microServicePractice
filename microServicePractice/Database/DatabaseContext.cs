using microServicePractice.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace microServicePractice.Database
{
    public class DatabaseContext:DbContext
    {
        public DbSet<ODBC> odbc_table { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-N5GEDBM; Initial Catalog = ODBCTEST;User ID = sa ,Password=Testing123$; Trusted_Connection=True;");
        }
    }
}
