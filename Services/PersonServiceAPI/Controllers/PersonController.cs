using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using JoySoftware.PersonService.Model;
using JoySoftware.PersonService.Contract;

namespace PersonServiceAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        //public PersonController()

        //{


        //}
        IPersonService personService = null;
        public PersonController(IPersonService personService)
        {
            this.personService = personService ?? throw new NullReferenceException("personService is null");
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //ToDo: fix
            return Ok (await personService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            Person p = await personService.GetPerson(id);

            if (p != null)
                return Ok(p);
            else
                return NotFound();
        }
    }
}