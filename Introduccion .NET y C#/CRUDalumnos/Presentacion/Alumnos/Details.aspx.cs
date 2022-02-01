using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocios;
using Entidades;
using System.Configuration;
using System.Data.SqlClient;

namespace Presentacion.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
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

        protected void btnIMSS_Click(object sender, EventArgs e)
        {
            NAlumno nalumno = new NAlumno();
            AportacionesIMSS aport = nalumno.CalcularIMSS(Convert.ToInt32(lblID.Text));
            EM.Text= aport.enfermedadMaternidad.ToString();
            IV.Text= aport.invalidezVida.ToString();
            RO.Text= aport.retiro.ToString();
            CA.Text= aport.cesantía.ToString();
            CI.Text= aport.infonavit.ToString();
            mpeModal.Show();
        }            
    }
}