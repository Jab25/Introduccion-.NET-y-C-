using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class ADOEstatus : ICRUDEstatus
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Estatus> listEstatus;
        string query;
        SqlCommand comando;

        public List<Estatus> consultar()
        {
            query = "select * from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                listEstatus = new List<Estatus>();
                while (reader.Read())
                {
                    listEstatus.Add(
                       new Estatus()
                       {
                           id = Convert.ToInt32(reader["id_EstatusAlumnos"]),
                           Clave = reader["Clave"].ToString(),
                           Nombre = reader["Nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return listEstatus;
        }
        public Estatus consultar(int id)
        {
            Estatus estatusPorUno = new Estatus();
            query = $"select * from EstatusAlumnos where id_EstatusAlumnos ={id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    estatusPorUno = new Estatus
                    {
                        id = Convert.ToInt32(reader["id_EstatusAlumnos"]),
                        Clave = reader["Clave"].ToString(),
                        Nombre = reader["Nombre"].ToString()
                    };
                }
                con.Close();
            }
            return estatusPorUno;
        }
        public int agregar(Estatus estatus)
        {
            int idEstado;
            query = $"insert into EstatusAlumnos(Clave,Nombre) values(@Clave, @Nombre)";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Clave", estatus.Clave);
                comando.Parameters.AddWithValue("@Nombre", estatus.Nombre);
                con.Open();
                idEstado = Convert.ToInt32(comando.ExecuteScalar());
                con.Close();
            }
            return idEstado;
        }
        public void actualizar(Estatus estatus)
        {
            string query = $"update EstatusAlumnos set Clave ='{estatus.Clave}', " +
                           $"Nombre ='{estatus.Nombre}' " +
                           $"where id_EstatusAlumnos={estatus.id}";

            using (SqlConnection conn = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, conn);
                comando.CommandType = CommandType.Text;
                conn.Open();
                comando.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Eliminar(int id)
        {
            query = $"delete EstatusAlumnos where id_EstatusAlumnos ={id}";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
