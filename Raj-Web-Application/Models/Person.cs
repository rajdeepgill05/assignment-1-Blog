﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raj_Web_Application.Models
{
    public class Person
    {
        public Person()
        {
            Cars = new HashSet<Car>();
            Houses = new HashSet<House>();
        }
        public string  Id { get; set; }
        public string DOB { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<House> Houses { get; set; }

    }
}