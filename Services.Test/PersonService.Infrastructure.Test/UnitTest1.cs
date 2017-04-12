using JoySoftware.PersonService.Infrastructure.Database;
using System;
using Xunit;
namespace PersonService.Infrastructure.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var personDb = new PersonDbRepository();
            personDb.Context.Database.Log = Console.Write;

            var allPersons = personDb.GetAll();

        }
    }
}
