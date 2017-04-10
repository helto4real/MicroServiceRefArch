using System;
using System.Collections.Generic;
using System.Text;

namespace PersonService.Model
{
    public class Person
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
