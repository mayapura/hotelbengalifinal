using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Habitacion
    {
        public int id { get; set; }
        public string numero { get; set; }
        public string estado { get; set; }
        public string tipo { get; set;}
        public Double precio { get; set;}

    }
}