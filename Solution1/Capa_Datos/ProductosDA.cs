using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    public class ProductosDA
    {
        private string conexion = "Data Source=VALENZUELA-PC\\SQLEXPRESS;Initial Catalog=Examen;user id= sa;password=sql;Integrated Security=true;";
        public List<ProductosBE> ListarProducto()
        {
            List<ProductosBE> Lista = new List<ProductosBE>();
            SqlConnection sql = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SELECT_PRODUCTO";
            sql.Open();
            SqlDataReader Dr;
            Dr = cmd.ExecuteReader();
            while (Dr.Read()) 
            {
                ProductosBE Entidad = new ProductosBE();
                Entidad.IdProducto =Convert.ToInt16(Dr[0].ToString());
                Entidad.Descripcion = Dr[1].ToString();
                Lista.Add(Entidad);
            }
            sql.Close();
            return Lista;
        
        }
    }
}
