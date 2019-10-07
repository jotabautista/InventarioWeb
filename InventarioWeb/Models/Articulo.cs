using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventarioWeb.Models
{
    public class Articulo
    {
        [Key]
        [Display(Name = "ID")]
        public int IdArticulo { get; set; }
        [StringLength(20)]
        public string Referencia { get; set; }
        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        public int Minimo { get; set; }
        [Required]
        public int Maximo { get; set; }
        [Required]
        public Estado? Estado { get; set; }
    }
}
