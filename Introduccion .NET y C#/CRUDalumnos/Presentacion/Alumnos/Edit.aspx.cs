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
    public partial class Edit : System.Web.UI.Page
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        List<Alumno> listAlumno;
        SqlCommand comando;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                id = id == null ? "14" : id;
                NAlumno nalumno = new NAlumno();
                Alumno alumno = nalumno.Consultar(int.Parse(id));
                txtID.Text = alumno.id.ToString();
                txtNombre.Text = alumno.nombre;
                txtPriApe.Text = alumno.primerApellido;
                txtSegApe.Text = alumno.segundoApellido;
                txtCorreo.Text = alumno.correo;
                txtTelefono.Text = alumno.telefono;
                txtFecNac.Text = alumno.fechaNacimiento.ToString("yyyy-MM-dd");
                txtCURP.Text = alumno.curp;
                ddlEstado.Text = alumno.idEstadoOrigen.ToString();
                ddlEstatus.Text = alumno.idEstatus.ToString();
            }
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
                    id = Convert.ToInt32(txtID.Text),
                    nombre = txtNombre.Text,
                    primerApellido = txtPriApe.Text,
                    segundoApellido = txtSegApe.Text,
                    correo = txtCorreo.Text,
                    telefono = txtTelefono.Text,
                    fechaNacimiento = Convert.ToDateTime(txtFecNac.Text),
                    curp = txtCURP.Text,
                    sueldo = 0,
                    idEstadoOrigen = Convert.ToInt32(ddlEstado.SelectedValue),
                    idEstatus = Convert.ToInt16(ddlEstatus.SelectedValue)
                }
                );
            }
            NAlumno nAlumno = new NAlumno();
            Alumno alumno = listAlumno.Find(x => x.id == Convert.ToInt32(txtID.Text));
            nAlumno.Actualizar(alumno);
        }
    }
}