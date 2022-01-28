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
    public class DEstatusAlumno
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<EstatusAlumno> listEstatus;
        string query;
        SqlCommand comando;

        public List<EstatusAlumno> consultar()
        {
            query = "select * from EstatusAlumnos";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                listEstatus = new List<EstatusAlumno>();
                while (reader.Read())
                {
                    listEstatus.Add(
                       new EstatusAlumno()
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
    }
}
