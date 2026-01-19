using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.ServiceModel;
using Entidades;

namespace WcfService1
{
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        List<Persona> ListarPersonas();

        [OperationContract]
        bool InsertarPersonas(string ApPaterno, string ApMaterno, string Nombre, bool Estado);
    }
}