using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Hotel_Bengali.Models
{
    public partial class hotelDbContext : DbContext
    {
        public hotelDbContext()
            : base("name=MiConexion")
        {
        }

        public DbSet<Pago>Pagos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
