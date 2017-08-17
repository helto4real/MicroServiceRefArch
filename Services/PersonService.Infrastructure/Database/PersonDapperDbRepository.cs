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
        #region -- Commmon SQL --

        string selectAllSQL = "select Id, FirstName LastName from Person";

        #endregion

        public PersonDapperDbRepository(string connectionString) : base(connectionString)
        {
           
        }


        public override void Add(Person entity)
        {
            throw new NotImplementedException();
        }

        public override async Task AddAsync(Person entity)
        {
            throw new NotImplementedException();
        }

        public override List<Person> All()
        {
            throw new NotImplementedException();
        }

        public override async Task<List<Person>> AllAsync()
        {

            var guid = Guid.NewGuid();
            IEnumerable<Person> persons = await connection.QueryAsync<Person>(selectAllSQL);

            return persons.ToList();
        }

        public override void Delete(Person entity)
        {
            throw new NotImplementedException();
        }

        public override Person GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public override void Update(Person entity)
        {
            throw new NotImplementedException();
        }

        public override void UpdateOrAdd(Person entity)
        {
            throw new NotImplementedException();
        }


    }
}
