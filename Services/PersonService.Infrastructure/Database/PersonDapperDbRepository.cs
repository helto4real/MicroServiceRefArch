using JoySoftware.Intrastructure.Base.Repository;
using JoySoftware.PersonService.Contract;
using JoySoftware.PersonService.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Threading.Tasks;
using System.Linq;

namespace JoySoftware.PersonService.Infrastructure.Database
{
    public class PersonDapperDbRepository : DapperRepository<Person>, IPersonSimpleRepository
    {
        public PersonDapperDbRepository(string connectionString) : base(connectionString) {}
    }
}
