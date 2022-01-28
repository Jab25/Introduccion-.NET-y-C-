using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaWindowsForms
{
    public partial class Form1 : Form
    {
        string conection = ConfigurationManager.ConnectionStrings["LocalConnection"].ConnectionString;
        string query;
        SqlCommand comando;
        ADOEstatus ado = new ADOEstatus();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarbmSeleccionar();
            LlenardgvDatos();
        }
        private void LlenarbmSeleccionar()
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
                con.Close();
                bmSeleccionar.DataSource = tabla;
                bmSeleccionar.ValueMember = "id_EstatusAlumnos";
                bmSeleccionar.DisplayMember = "Nombre";
            }
        }
        private void LlenardgvDatos()
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
                con.Close();
                dgvDatos.DataSource = tabla;
            }
        }
        private void bmSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar.Visible = true;
            btnModificar.Enabled = false;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Agregar.Visible = true;
            btnModificar.Enabled = true;
            var id = Convert.ToInt32(bmSeleccionar.SelectedValue);
            Estatus item = ado.consultar(id);
            txtNombre.Text = item.Nombre;
            txtClave.Text = item.Clave;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(bmSeleccionar.SelectedValue);
            DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ado.Eliminar(id)
;
                MessageBox.Show("Registro eliminado Exitosamente.");
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Enabled == false)
            {
                string nombre = txtNombre.Text;
                string clave = txtClave.Text;
                Estatus estatus = new Estatus { Clave = clave, Nombre = nombre };
                ado.agregar(estatus);
                txtClave.Clear();
                txtNombre.Clear();
                btnModificar.Enabled = true;
                MessageBox.Show("Registro agregado.");
            }
            else if (btnModificar.Enabled == true)
            {
                string nom = txtNombre.Text;
                string abrev = txtClave.Text;
                var idN = Convert.ToInt32(bmSeleccionar.SelectedValue);
                Estatus Nestatus = new Estatus { id = idN, Nombre = nom, Clave = abrev };
                ado.actualizar(Nestatus);
                MessageBox.Show("Registro actualizado.");
                txtClave.Clear();
                txtNombre.Clear();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Agregar.Visible = false;
            btnModificar.Enabled = true;
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LlenardgvDatos();
            LlenarbmSeleccionar();
        }
    }
}
