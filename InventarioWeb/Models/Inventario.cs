using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioWeb.Models
{
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }
        public int IdAlmacen { get; set; }
        public int IdArticulo { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }
        public int Documento { get; set; }
        public decimal Precio { get; set; }
    }
}
