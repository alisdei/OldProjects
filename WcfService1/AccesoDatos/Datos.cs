using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class Datos
    {
        string conexion = "Data Source = VALENZUELA-PC\\SQLEXPRESS;Initial Catalog = EXAMEN;User ID=sa;Password=sql";
        public List<Persona> ListarPersonas()
        {
            List<Persona> Lista = new List<Persona>();            
            SqlConnection cn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader Dr;
            
            cmd.Connection = cn;
            cmd.CommandText = "LISTAR_PERSONAS";
            cmd.CommandType = CommandType.StoredProcedure;
            
            try
            {
                cn.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    Persona Entidad = new Persona();
                    Entidad.Id = int.Parse(Dr[0].ToString());
                    Entidad.ApMaterno = Dr[1].ToString();
                    Entidad.ApPaterno = Dr[2].ToString();
                    Entidad.Nombre = Dr[3].ToString();
                    Entidad.Estado = bool.Parse(Dr[4].ToString());
                    Lista.Add(Entidad);
                }
                
            }
            catch (Exception ex)
            {
                   
            }finally
            {
              cn.Close();
            }
            return Lista;
        }

        public bool InsertarPersonas(string ApPaterno,string ApMaterno,string Nombre,bool Estado)
        {
            bool Result = false;
            SqlConnection cn = new SqlConnection(conexion);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERTAR_PERSONAS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@APPATERNO",SqlDbType.VarChar).Value = ApPaterno;
            cmd.Parameters.Add("@APMATERNO",SqlDbType.VarChar).Value = ApMaterno;
            cmd.Parameters.Add("@NOMBRE",SqlDbType.VarChar).Value = Nombre;
            cmd.Parameters.Add("@ESTADO",SqlDbType.Bit).Value = Estado;

            try
            {
                cn.Open();
                Result = Convert.ToBoolean(cmd.ExecuteNonQuery().ToString());

            }
            catch
            {

            }
            finally {
                cn.Close();
            }
            return Result;
        }
    }
}
