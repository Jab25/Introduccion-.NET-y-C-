using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Presentacion.Alumnos
{
    public partial class Create : System.Web.UI.Page
    { 
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Alumno> listAlumno;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                llenarcamposEstados();
                llenarcamposEstatus();  
            }
        }

        void llenarcamposEstados()
            {
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();
                    DataSet dt = new DataSet();
                    comando = new SqlCommand("consultarTodosEstados", con);
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable tabla = new DataTable();
                    da.SelectCommand = comando;
                    da.Fill(tabla);
                    ddlEstado.DataSource = tabla;
                    ddlEstado.DataTextField = "nombre";
                    ddlEstado.DataValueField = "id_Estados";
                    ddlEstado.DataBind();
                    con.Close();
                }
            }
        }
        void llenarcamposEstatus()
        {
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(conection))
                {
                    con.Open();
                    DataSet dt = new DataSet();
                    comando = new SqlCommand("consultartodosEstatus", con);
                    comando.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataTable tabla = new DataTable();
                    da.SelectCommand = comando;
                    da.Fill(tabla);
                    ddlEstatus.DataSource = tabla;
                    ddlEstatus.DataTextField = "Nombre";
                    ddlEstatus.DataValueField = "id_EstatusAlumnos";
                    ddlEstatus.DataBind();
                    con.Close();
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            listAlumno = new List<Alumno>();
            {
                listAlumno.Add(new Alumno
                {
                    //id = 1,
                    nombre = txtNombre.Text,
                    primerApellido = txtPriApe.Text,
                    segundoApellido = txtSegApe.Text,
                    correo = txtCorreo.Text,
                    telefono = txtTelefono.Text,
                    fechaNacimiento = Convert.ToDateTime(txtFecNac.Text.ToString()),
                    curp = txtCURP.Text,
                    sueldo = 0,
                    idEstadoOrigen = Convert.ToInt32(ddlEstado.SelectedValue),
                    idEstatus = Convert.ToInt16(ddlEstatus.SelectedValue)
                }
                );
            }
            NAlumno nAlumno = new NAlumno();
            Alumno alumno = listAlumno.Find(x => x.id == 0);
            nAlumno.Agregar(alumno);
        }
    }
}