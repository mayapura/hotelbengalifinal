using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class ProductoServicio
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Double precio { get; set;}
        public string descripcion { get; set;}
        public string categoria { get; set;}
        public string disponibilidad { get; set; }
        public string imagen { get; set; }

    }
}