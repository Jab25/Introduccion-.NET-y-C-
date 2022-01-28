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
    public partial class Delete : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string query;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            lblid.Text = id;
            string Nombre = Request.QueryString["nom"];
            lblNombre.Text = Nombre;
            string Clave = Request.QueryString["Clave"];
            lblClave.Text = Clave;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblid.Text);
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