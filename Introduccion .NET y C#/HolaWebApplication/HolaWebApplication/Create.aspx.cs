using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaWebApplication
{
    public partial class Create : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string query;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEstado;
            query = $"insert into EstatusAlumnos(Clave,Nombre) values(@Clave, @Nombre)";
            using (SqlConnection con = new SqlConnection(conection))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                comando.Parameters.AddWithValue("@Clave", txtClave.Text);
                con.Open();
                idEstado = Convert.ToInt32(comando.ExecuteScalar());
                con.Close();
            }
            Response.Write("<script>alert('Agregado exitosamente.');</script>");
        }
    }
}