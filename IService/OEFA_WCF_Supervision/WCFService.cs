using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using Oefa.Siia.Service;

namespace Oefa.Siia.WCFServiceHost
{
    public partial class WCFService : ServiceBase
    {
        public WCFService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Servicio));
            host.Open();
        }

        protected override void OnStop()
        {
        }
    }
}
