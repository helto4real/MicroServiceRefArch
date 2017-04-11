using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using JoySoftware.PersonService.Model;

namespace JoySoftware.PersonService.Infrastructure.Database
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PersonServiceDb;Trusted_Connection=True;");
        }
    }
}
