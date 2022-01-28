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
    public partial class Edit : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string query;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String Nombre = Request.QueryString["nom"];
                txtNombre.Text = Nombre;
                string Clave = Request.QueryString["Clave"];
                txtClave.Text = Clave;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
                int id = int.Parse(Request.QueryString["id"]);
                string nombre = txtNombre.Text;
                string clave = txtClave.Text;
                string query = $"update EstatusAlumnos set Clave ='{clave}', " +
                               $"Nombre ='{nombre}' " +
                               $"where id_EstatusAlumnos={id}";

                using (SqlConnection conn = new SqlConnection(conection))
                {
                    comando = new SqlCommand(query, conn);
                    comando.CommandType = CommandType.Text;
                    conn.Open();
                    comando.ExecuteNonQuery();
                    conn.Close();
                
            }
        }
    }
}