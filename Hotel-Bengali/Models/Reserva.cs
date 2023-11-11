using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Reserva
    {
        public int id { get; set; }
        public Reserva reserva { get; set; }
        public Habitacion habitacion { get; set; }
        public DateTime fecjaIngreso { get; set; }
        public DateTime fechaEgreso { get; set; }
        public string estado { get;set; }

    }
}