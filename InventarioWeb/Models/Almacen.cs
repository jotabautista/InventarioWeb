using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace InventarioWeb.Models
{

    public class Almacen
    {

        [Key]
        [Display(Name = "ID")]
        public int IdAlmacen { get; set; }
        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }
        [Required]
        [StringLength(300)]
        public string Ubicacion{ get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Required]
        [DisplayName("Tipo Almacen")]
        public TipoAlmacen? Tipo { get; set; }
        [Required]
        public Estado? Estado { get; set; }

        public ICollection<MovimientoDet> MovimientoDets { get; set; }
    }
}
