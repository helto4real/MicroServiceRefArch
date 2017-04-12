using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using JoySoftware.PersonService.Contract;
using JoySoftware.PersonService.Model;
using JoySoftware.Intrastructure.Base.Repository.Database.EF;

namespace JoySoftware.PersonService.Infrastructure.Database
{
    public class PersonDbRepository : EntityFrameworkRepository<PersonDbContext, Person>
    {
       
    }
}
