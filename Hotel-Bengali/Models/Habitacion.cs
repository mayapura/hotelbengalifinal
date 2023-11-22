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
        public double Precio { get; set;}

        // Relación con Reserva (uno a muchos)
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}