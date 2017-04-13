using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using JoySoftware.PersonService.Model;

namespace JoySoftware.PersonService.Infrastructure.Database
{
    public class PersonDbContext : DbContext
    {
        private string connectionString = null;

        public PersonDbContext() { }

        /// <summary>
        ///  Mainly used for testing, normal case the settings is set during dependency injection
        /// </summary>
        /// <param name="connectionString">The connectionstring to the database used</param>
        public PersonDbContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbSet<Person> Person { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (connectionString != null)
                optionsBuilder.UseSqlServer(connectionString); // @"Server=(localdb)\mssqllocaldb;Database=PersonServiceDb;Trusted_Connection=True;");
        }
    }
}
