using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project2MovieMate
{
    class MyDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseSqlite("Data Source=movieDB.db");
        }
    }
}
