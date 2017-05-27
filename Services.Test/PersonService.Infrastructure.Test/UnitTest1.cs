using JoySoftware.PersonService.Infrastructure.Database;
using System;
using Xunit;
using System.Linq;

namespace PersonService.Infrastructure.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (var context = new PersonDbContext( @"Server=(localdb)\mssqllocaldb;Database=PersonServiceDb;Trusted_Connection=True;"))
            {
                var personDb = new PersonDbRepository(context);

                var allPersons = personDb.GetById(Guid.Parse("e31f83aa-3c08-4957-aba9-3e305725be26"));
            }
                
            //personDb.Context.Database.Log = Console.Write;

           

        }
    }
}
