using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioWebRest.Areas.Api.Models
{
    public class Cliente
    {
        public int Idcliente { get; set; }
        public string Nomcliente { get; set; }
        public string Apellidopat { get; set; }
        public string Apellidomat { get; set; }
        public int Dni { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
    }
}