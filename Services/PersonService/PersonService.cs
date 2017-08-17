using JoySoftware.PersonService.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using JoySoftware.PersonService.Model;
using System.Linq;
using System.Threading.Tasks;

namespace JoySoftware.PersonService
{
    //ToDo: Add validation etc later...
    public class PersonService : IPersonService
    {
        IPersonRepository personRepository = null;
        IPersonSimpleRepository personSimpleRepository = null;

       
       
        public PersonService(IPersonRepository repository, IPersonSimpleRepository simpleRepository)
        {
            this.personRepository = repository;
            this.personSimpleRepository = simpleRepository;
        }

        public async Task< IEnumerable<Person>> GetAll()
        {
           // return await personRepository.AllAsync();

            return await personSimpleRepository.AllAsync();

        }

        public async Task<Person> GetPerson(Guid personId)
        {
            var person = await personSimpleRepository.GetByIdAsync(personId);

            return person;
        }

        public async Task RegisterNewPerson(Person p)
        {
            await personRepository.AddAsync(p);

        }
    }
}
