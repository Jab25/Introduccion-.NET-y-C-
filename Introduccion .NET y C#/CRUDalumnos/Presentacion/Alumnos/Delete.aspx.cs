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
    public partial class Delete : System.Web.UI.Page
    {
        NAlumno nalumno = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                id = id == null ? "13" : id;
                
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

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblID.Text);
            nalumno.Eliminar(id);
        }
    }
}