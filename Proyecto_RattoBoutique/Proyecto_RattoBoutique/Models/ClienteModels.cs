using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Proyecto_RattoBoutique.Models
{
    public class ClienteModels
    {
        [Key]
        public int ClienteID { get; set; }

        [Display(Name = "Organización:")]
        public string Descripcion { get; set; }

        [Display(Name = "Nombres:")]
        public string Nombres { get; set; }

        [Display(Name = "Apellido Paterno:")]
        public string ApellidoPaterno { get; set; }

        [Display(Name = "Apellido Materno:")]
        public string ApellidoMaterno { get; set; }

        public int TipoClienteID { get; set; }
        public virtual TipoClienteModels TipoCliente { get; set; }

        [MaxLength(8)]
        public Int64 Dni { get; set; }

        [Display(Name = "Ruc:")]
        [MaxLength(11)]
        public Int64 NroRuc { get; set; }

        public string Correo { get; set; }

        [Display(Name = "Telefono 1:")]
        public Int64 PTelefono { get; set; }

        [Display(Name = "Telefono 2:")]
        public Int64 STelefono { get; set; }

        [DataType(DataType.MultilineText)]
        public string Direccion { get; set; }

        [DataType(DataType.MultilineText)]
        public string Observacion { get; set; }

        public bool Estado { get; set; }
    }
}