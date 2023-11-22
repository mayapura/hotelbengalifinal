using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public double Monto { get; set; }
        public DateTime FechaPago { get; set; }
        public string FormaPago { get; set; }

        // Relación con Reserva (muchos a uno)
        public int ReservaId { get; set; }
        public virtual Reserva Reserva { get; set; }

    }          
}