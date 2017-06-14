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

        public PersonService(IPersonRepository repository)
        {
            personRepository = repository;
        }

        public async Task< IEnumerable<Person>> GetAll()
        {
            return await personRepository.GetAllAsync();

        }

        public async Task<Person> GetPerson(Guid personId)
        {
            var personList = await personRepository.FindByAsync(s => s.Id == personId);

            return personList.FirstOrDefault();
        }

        public async Task RegisterNewPerson(Person p)
        {
            await personRepository.AddAsync(p);

        }
    }
}
