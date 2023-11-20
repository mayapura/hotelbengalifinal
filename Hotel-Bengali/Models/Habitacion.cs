using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Estado { get; set; }
        public string Tipo { get; set;}
        public Double Precio { get; set;}

    }
}