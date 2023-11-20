using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public Double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string FormaPago { get; set; }
        public Reserva Reserva { get; set; }

    }          
}