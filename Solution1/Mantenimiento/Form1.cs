using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using Capa_Entidades;
namespace Mantenimiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductosBL obj = new ProductosBL();
            comboBox1.DataSource = obj.ListarProducto();
            comboBox1.DisplayMember = "Descripcion";
            comboBox1.ValueMember = "IdProducto";
        }
    }
}
