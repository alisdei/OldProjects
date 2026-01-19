using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSolGas.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        [StringLength(12)]
        public string Codigo { get; set; }

        [StringLength(50)]
        [Display(Name = "Producto")]
        public string Descripcion { get; set; }

        public int ValvulaID { get; set; }
        public virtual Valvula Valvula { get; set; }

        [Range(0, 100)]
        public int Peso { get; set; }

    }
}