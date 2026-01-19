using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ServiceModel;
using System.ServiceProcess;
using System.Configuration;
using System.Configuration.Install;
using Oefa.Siia.IService;

namespace Oefa.Siia.Service
{
    public class Servicio:IServicio
    {
        public string Mensaje(string msg)
        {
            return msg;
        }
    }
}
