using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioWeb.Models
{
    public class MovimientoDet
    {
        [Key]
        [Display(Name = "ID")]
        public int IdMovimientoDet { get; set; }
        [Required]
        public int IdMovimiento { get; set; }
        [Required]
        public int IdArticulo { get; set; }
        [Required]
        public int IdAlmacen { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Precio { get; set; }

        public virtual Movimiento Movimiento { get; set; }
        public virtual Articulo Articulo { get; set; }
        public virtual Almacen Almacen { get; set; }
    }
}
