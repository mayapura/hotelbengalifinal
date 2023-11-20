using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public int NumeroReserva { get; set; }
        public Habitacion Habitacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public string Estado { get;set; }

    }
}