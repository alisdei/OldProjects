using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proyecto_RattoBoutique.Models
{
    public class TipoClienteModels
    {
        [Key]
        public int TipoClienteID { get; set; }

        public string Descripcion { get; set; }

        [DataType(DataType.MultilineText)]
        public string Observacion { get; set; }

        public bool Estado { get; set; }
    }
}