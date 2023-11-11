using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Domicilio
    {
        public int id { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string ciudad { get; set; }
        public string codigoPostal { get; set; }
        public string pais { get; set; }
        public string provincia { get; set; }
    }
}