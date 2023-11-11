using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Pago
    {
        public int id { get; set; }
        public Double monto { get; set; }
        public DateTime fechaPago { get; set; }
        public string formaPago { get; set; }
        public Reserva reserva { get; set; }

    }          
}