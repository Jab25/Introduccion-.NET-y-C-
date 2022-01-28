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
    public partial class inicio : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string query;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();
                    DataSet dt = new DataSet();
                    query = "select * from EstatusAlumnos";
                    comando = new SqlCommand(query, con);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = comando;
                    DataTable tabla = new DataTable();
                    da.Fill(tabla);

                    listContenido.DataSource = tabla;
                    listContenido.DataTextField = "Nombre";
                    listContenido.DataValueField = "id_EstatusAlumnos";
                    listContenido.DataBind();
                    con.Close();
                }
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listContenido.SelectedValue);
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                query = $"select * from EstatusAlumnos where id_EstatusAlumnos={id}";
                comando = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                string nombre = tabla.Rows[0]["Nombre"].ToString();
                string clave = tabla.Rows[0]["Clave"].ToString();

                string url = $"Details.aspx?id={id}&nom={nombre}&clave={clave}";
                Response.Redirect(url,true);
            con.Close();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listContenido.SelectedValue);
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                query = $"select * from EstatusAlumnos where id_EstatusAlumnos={id}";
                comando = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                string nombre = tabla.Rows[0]["Nombre"].ToString();
                string clave = tabla.Rows[0]["Clave"].ToString();

                string url = $"Edit.aspx?id={id}&nom={nombre}&clave={clave}";
                Response.Redirect(url, true);
                con.Close();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listContenido.SelectedValue);
            using (SqlConnection con = new SqlConnection(conection))
            {
                con.Open();
                DataSet dt = new DataSet();
                query = $"select * from EstatusAlumnos where id_EstatusAlumnos={id}";
                comando = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comando;
                DataTable tabla = new DataTable();
                da.Fill(tabla);
                string nombre = tabla.Rows[0]["Nombre"].ToString();
                string clave = tabla.Rows[0]["Clave"].ToString();

                string url = $"Delete.aspx?id={id}&nom={nombre}&clave={clave}";
                Response.Redirect(url, true);
                con.Close();
            }
        }

        protected void listContenido_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}