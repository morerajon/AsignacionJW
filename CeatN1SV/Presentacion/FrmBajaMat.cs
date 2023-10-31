using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;

namespace Presentacion
{
    public partial class FrmBajaMat : Form
    {
        Conexion claseConexion = new Conexion();
        DataTable Tabla = new DataTable();

        public FrmBajaMat()
        {
            InitializeComponent();
        }



        private void FrmBajaMat_Load(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT * FROM Alumno"));
            dgvMatriculas.DataSource = Tabla;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
         if (dgvMatriculas.SelectedRows.Count > 0)
            {
                lblNombre.Text = "Nombre : " + dgvMatriculas.CurrentRow.Cells["Alumno_Nombres"].Value.ToString();
                lblApellido.Text = "Apellido : " + dgvMatriculas.CurrentRow.Cells["Alumno_Apellidos"].Value.ToString();
                lblDNI.Text = "DNI : " + dgvMatriculas.CurrentRow.Cells["Alumno_Dni"].Value.ToString();
                lblGrado.Text = "Grado : Deambulante";

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void dgvMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnGuardarBaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Se dará de baja a : \n" + lblNombre.Text + "\n" + lblApellido.Text + "\n" + lblDNI.Text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
               // aca  llama al metodo que graba en la base de datos
                lblNombre.Text = "Nombre :";
                lblApellido.Text = "Apellido : ";
                lblDNI.Text = "DNI : " ;
                lblGrado.Text = "Grado :";
                txtBajaCausa.Text = "";
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT * FROM Alumno WHERE Alumno_Nombres LIKE '%" + busqueda + "%' OR Alumno_Apellidos LIKE '%" + busqueda + "%' OR Alumno_Dni LIKE '%" + busqueda + "%' ORDER BY Alumno_Apellidos;"));
            dgvMatriculas.DataSource = Tabla;
        }


        

    }
}
