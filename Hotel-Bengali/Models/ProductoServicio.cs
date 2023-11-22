using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class ProductoServicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set;}
        public string Descripcion { get; set;}
        public string Categoria { get; set;}
        public string Disponibilidad { get; set; }
        public string Imagen { get; set; }

        // Relación muchos a muchos con Reserva
        public virtual ICollection<Reserva> Reservas { get; set; }

    }
}