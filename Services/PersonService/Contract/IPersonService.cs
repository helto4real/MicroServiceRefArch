using PersonService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonService.Contract
{
    public interface IPersonService
    {
        Person GetPerson(Guid personId);

        void RegisterNewPerson(Person p);

    }
}
