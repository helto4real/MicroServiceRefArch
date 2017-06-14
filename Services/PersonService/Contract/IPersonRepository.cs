using JoySoftware.Intrastructure.Base.Repository;
using JoySoftware.PersonService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JoySoftware.PersonService.Contract
{
    public interface IPersonRepository : IRepository<Person>
    {
    }

    public interface IPersonSimpleRepository : ISimpleRepository<Person>
    {

    }
}
