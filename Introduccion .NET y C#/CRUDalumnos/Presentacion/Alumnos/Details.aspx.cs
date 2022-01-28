using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Entidades;

namespace Presentacion.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                id = id == null ? "13" : id;
                NAlumno nalumno = new NAlumno();
                Alumno alumno = nalumno.Consultar(int.Parse(id));
                lblID.Text = alumno.id.ToString();
                lblNombre.Text = alumno.nombre; 
                lblPriApe.Text = alumno.primerApellido;
                lblSegApe.Text = alumno.segundoApellido;
                lblFecNac.Text = alumno.fechaNacimiento.ToString();
                lblCURP.Text = alumno.curp;
                lblCorreo.Text = alumno.correo;
                lblTelefono.Text = alumno.telefono;
                lblEstado.Text = alumno.idEstadoOrigen.ToString();
                lblEstatus.Text = alumno.idEstatus.ToString();
            }
        }
    }
}