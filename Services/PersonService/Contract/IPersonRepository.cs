using JoySoftware.Intrastructure.Base.Repository;
using PersonService.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonService.Contract
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
