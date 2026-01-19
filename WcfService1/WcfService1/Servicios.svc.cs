using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entidades;
using AccesoDatos;
namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Servicios" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Servicios.svc or Servicios.svc.cs at the Solution Explorer and start debugging.
    public class Servicios : IServicio
    {

        public List<Persona> ListarPersonas()
        {
            Datos obj = new Datos();
            return obj.ListarPersonas();
        }

        public bool InsertarPersonas(string ApPaterno, string ApMaterno, string Nombre, bool Estado)
        {
            Datos obj = new Datos();
            return obj.InsertarPersonas(ApPaterno, ApMaterno, Nombre, Estado);
        }
    }
}
