using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Bengali.Models
{
    public class Huesped
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Genero { get; set; }
        public int Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Nacionalidad { get; set; }

        // Relación con Domicilio (uno a muchos)
        public int DomicilioId { get; set; }
        public virtual Domicilio Domicilio { get; set; }

        // Relación muchos a muchos con Reserva
        public virtual ICollection<Reserva> Reservas { get; set; }

    }
}