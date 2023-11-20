using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class vista
    {
        public Huesped Huesped { get; set; }
        public Domicilio Domicilio { get; set; }
        public Habitacion Habitacion { get; set; }
        public Reserva Reserva { get; set; }
        public ProductoServicio ProductoServicio { get; set;}
        public Pago Pago { get; set; }
    }
}