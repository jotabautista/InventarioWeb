using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioWeb.Models
{
    public class Movimiento
    {
        [Key]
        [Display(Name = "ID")]
        public int IdMovimiento { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }
        [Required]
        [DisplayName("Tipo Movimiento")]
        public TipoMovimiento? Tipo { get; set; }
        [Required]
        public Estado? Estado { get; set; }

        public ICollection<MovimientoDet> MovimientoDets { get; set; }
    }
}
