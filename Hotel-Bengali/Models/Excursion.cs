using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Excursion
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string NombreExcursion { get; set;}
        public DateTime FechaInicio { get; set;}
        public bool EstaPagado { get; set;}
        public decimal Precio { get; set;}

    }
}