using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JoySoftware.PersonService.Model;

namespace PersonServiceAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            //ToDo: fix
            return new List<Person>();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            return "value";
        }
    }
}