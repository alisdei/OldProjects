using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ListarPersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            ServiceReference1.Persona[] Listado = new ServiceReference1.ServicioClient().ListarPersonas();
            grvListado.DataSource = Listado;
            grvListado.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            bool Result = new ServiceReference1.ServicioClient().InsertarPersonas(TextBox1.Text, TextBox2.Text, TextBox3.Text, CheckBox1.Checked);
            if (Result)
            {
                Label1.Text = "Insertado Correctamente";
            }
        }
    }
}