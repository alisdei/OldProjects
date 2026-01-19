using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ServicioWebRest.Areas.Api.Models
{
    public class ClienteManager
    {
        private static string cadenaConexion =
           @"Data Source=VALENZUELA-PC\SQLEXPRESS;Initial Catalog=VENTA_COMPUTADORAS;User ID=sa;Password=sql";

        public bool InsertarCliente(Cliente cli)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);

            con.Open();

            string sql = "INSERT INTO TBL_CLIENTE (NOMCLIENTE,APELLIDOPAT,APELLIDOMAT,DNI,DIRECCION,TELEFONO,EMAIL,ESTADO) VALUES (@nombre, @apellidopat,@apellidomat,@dni,@direccion,@telefono,@email,@estado)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar).Value = cli.Nomcliente;
            cmd.Parameters.Add("@apellidopat", System.Data.SqlDbType.NVarChar).Value = cli.Apellidopat;
            cmd.Parameters.Add("@apellidomat", System.Data.SqlDbType.NVarChar).Value = cli.Apellidomat;
            cmd.Parameters.Add("@dni", System.Data.SqlDbType.Int).Value = cli.Dni;
            cmd.Parameters.Add("@direccion", System.Data.SqlDbType.NVarChar).Value = cli.Direccion;
            cmd.Parameters.Add("@telefono", System.Data.SqlDbType.Int).Value = cli.Telefono;
            cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = cli.Email;
            cmd.Parameters.Add("@estado", System.Data.SqlDbType.Bit).Value = cli.Estado;

            int res = cmd.ExecuteNonQuery();

            con.Close();

            return (res == 1);
        }

        public bool ActualizarCliente(Cliente cli)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);

            con.Open();

            string sql = "UPDATE TBL_CLIENTE SET NOMCLIENTE = @nombre,APELLIDOPAT=@apellidopat,APELLIDOMAT=@apellidomat,DNI=@dni,DIRECCION=@direccion,TELEFONO=@telefono,EMAIL=@email WHERE IDCLIENTE = @idcliente";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("@nombre", System.Data.SqlDbType.NVarChar).Value = cli.Nomcliente;
            cmd.Parameters.Add("@apellidopat", System.Data.SqlDbType.NVarChar).Value = cli.Apellidopat;
            cmd.Parameters.Add("@apellidomat", System.Data.SqlDbType.NVarChar).Value = cli.Apellidomat;
            cmd.Parameters.Add("@dni", System.Data.SqlDbType.Int).Value = cli.Dni;
            cmd.Parameters.Add("@direccion", System.Data.SqlDbType.NVarChar).Value = cli.Direccion;
            cmd.Parameters.Add("@telefono", System.Data.SqlDbType.Int).Value = cli.Telefono;
            cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = cli.Email;
            cmd.Parameters.Add("@estado", System.Data.SqlDbType.Bit).Value = cli.Estado;

            int res = cmd.ExecuteNonQuery();

            con.Close();

            return (res == 1);
        }

        public Cliente ObtenerCliente(int id)
        {
            Cliente cli = null;

            SqlConnection con = new SqlConnection(cadenaConexion);

            con.Open();

            string sql = "SELECT IDCLIENTE,NOMCLIENTE,APELLIDOPAT,APELLIDOMAT,DNI,DIRECCION,TELEFONO,EMAIL FROM TBL_CLIENTE WHERE IDCLIENTE = @idcliente and ESTADO=1";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("@idcliente", System.Data.SqlDbType.NVarChar).Value = id;

            SqlDataReader reader =
                cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            if (reader.Read())
            {
                cli = new Cliente();
                cli.Idcliente = reader.GetInt32(0);
                cli.Nomcliente = reader.GetString(1);
                cli.Apellidopat = reader.GetString(2);
                cli.Apellidomat = reader.GetString(3);
                cli.Dni = reader.GetInt32(4);
                cli.Direccion = reader.GetString(5);
                cli.Telefono = reader.GetInt32(6);
                cli.Email = reader.GetString(7);
            }

            reader.Close();

            return cli;
        }

        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            SqlConnection con = new SqlConnection(cadenaConexion);

            con.Open();

            string sql = "SELECT IDCLIENTE, NOMCLIENTE,APELLIDOPAT,APELLIDOMAT,DNI,DIRECCION,TELEFONO,EMAIL FROM TBL_CLIENTE WHERE ESTADO=1";

            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader reader =
                cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            while (reader.Read())
            {
                Cliente cli = new Cliente();

                cli = new Cliente();
                cli.Idcliente = reader.GetInt32(0);
                cli.Nomcliente = reader.GetString(1);
                cli.Apellidopat = reader.GetString(2);
                cli.Apellidomat = reader.GetString(3);
                cli.Dni = reader.GetInt32(4);
                cli.Direccion = reader.GetString(5);
                cli.Telefono = reader.GetInt32(6);
                cli.Email = reader.GetString(7);

                lista.Add(cli);
            }

            reader.Close();

            return lista;
        }

        public bool EliminarCliente(int id)
        {
            SqlConnection con = new SqlConnection(cadenaConexion);

            con.Open();

            string sql = "DELETE FROM TBL_CLIENTE WHERE IDCLIENTE = @idcliente";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.Add("@idcliente", System.Data.SqlDbType.Int).Value = id;

            int res = cmd.ExecuteNonQuery();

            con.Close();

            return (res == 1);
        }
    }
}