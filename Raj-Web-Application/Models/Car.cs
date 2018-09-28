using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raj_Web_Application.Models
{
    public class Car
    {
        

        public int Id { get; set; }
        public int Cost { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public DateTimeOffset Created { get;  set; }
        public virtual ApplicationUser Person { get; set; }
        
    }
}