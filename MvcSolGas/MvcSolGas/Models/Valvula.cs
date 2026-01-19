using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcSolGas.Models
{
    public class Valvula
    {
        public int ValvulaID { get; set; }

        [StringLength(50)]
        [Display(Name = "Valvula")]
        public string Descripcion { get; set; }
    }
}