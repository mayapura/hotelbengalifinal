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
        //public Habitacion Habitacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public string Estado { get;set; }

        // Relación muchos a muchos con Huesped
        public virtual ICollection<Huesped> Huespedes { get; set; }

        // Relación muchos a muchos con ProductoServicio
        public virtual ICollection<ProductoServicio> ProductoServicios { get; set; }

        // Relación con Pago (uno a muchos)
        public virtual ICollection<Pago> Pagos { get; set; }

        // Relación con Habitacion (uno a muchos)
        public int HabitacionId { get; set; }
        public virtual Habitacion Habitacionn { get; set; }

    }
}