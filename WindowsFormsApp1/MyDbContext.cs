using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Project2MovieMate
{
    internal class MyDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public void ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseSqlite("Data Source=movies.db");
        }
    }
}
