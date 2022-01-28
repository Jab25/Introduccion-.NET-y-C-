using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class DEstado
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Estado> listEstado;
        string query;
        SqlCommand comando;

        public List<Estado> consultar()
        {
            query = "select * from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                listEstado = new List<Estado>();
                while (reader.Read())
                {
                    listEstado.Add(
                       new Estado()
                       {
                           Id = Convert.ToInt32(reader["id_EstatusAlumnos"]),
                           Nombre = reader["Nombre"].ToString()
                       }
                       );
                }
                con.Close();
            }
            return listEstado;
        }
    }
}
