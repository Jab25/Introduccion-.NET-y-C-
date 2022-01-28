using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion.Alumnos
{
    public partial class Index : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarcamposAlumnos();
            }
        }
        void llenarcamposAlumnos()
        {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();
                    DataSet dt = new DataSet();
                    comando = new SqlCommand("consultarLista", con);
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable tabla = new DataTable();
                    da.SelectCommand = comando;
                    da.Fill(tabla);
                    gvLista.DataSource = tabla;
                    gvLista.DataBind();
                    con.Close();
                }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx", true);
        }

        protected void gvLista_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void gvLista_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Page") return;
                int iren = Convert.ToInt32(e.CommandArgument);
                GridViewRow ren = gvLista.Rows[iren];
                TableCell celda = ren.Cells[0];
                string id = celda.Text;
                switch (e.CommandName)
                {
                    case "Detalles":
                        Response.Redirect($"Details.aspx?id={id}", true);
                        break;
                    case "Editar":
                        Response.Redirect($"Edit.aspx?id={id}", true);
                        break;
                    case "Eliminar":
                        Response.Redirect($"Delete.aspx?id={id}", true);
                        break;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void gvLista_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLista.PageIndex = e.NewPageIndex;
            llenarcamposAlumnos();
        }
    }
}