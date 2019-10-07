using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventarioWeb.Models
{
    public class InventarioDBContext: DbContext
    {
        public InventarioDBContext(DbContextOptions<InventarioDBContext> options) : base(options)
        {
        }
        public DbSet<Almacen> Almacen { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<Movimiento> Movimiento{ get; set; }
        public DbSet<MovimientoDet> MovimientoDet { get; set; }
        public DbSet<Inventario> Inventario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }
    }
}
