using JoySoftware.PersonService.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JoySoftware.PersonService.Contract
{
    public interface IPersonService
    {
        Task <Person> GetPerson(Guid personId);

        Task <IEnumerable<Person>> GetAll();

        Task RegisterNewPerson(Person p);

    }
}
