﻿using PersonService.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using PersonService.Model;
using System.Linq;

namespace PersonService
{
    //ToDo: Add validation etc later...
    class PersonService : IPersonService
    {
        IPersonRepository personRepository = null;

        private PersonService(IPersonRepository repository)
        {
            personRepository = repository;
        }
        public Person GetPerson(Guid personId)
        {
            return personRepository.FindBy(s => s.Id == personId).FirstOrDefault();
        }

        public void RegisterNewPerson(Person p)
        {
            personRepository.Add(p);
        }
    }
}
