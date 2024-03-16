using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
using System.Data.OleDb;


namespace Presentacion
{
    public partial class FrmUsuario : Form
    {
        

        Conexion claseConexion = new Conexion();
        DataTable Tabla = new DataTable();

        public FrmUsuario()
        {
            InitializeComponent();
        }


        
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Usuario.Usuario_DNI, Usuario.Usuario_Alias, Permisos.Permiso_Categoria " +
                "FROM Usuario INNER JOIN Permisos ON Usuario.Usuario_Permisos = Permisos.Id  where Usuario.Usuario_Baja = false;"));
            dgvMatriculas.DataSource = Tabla;

        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmUsuarioPerfil frmPerfil = new FrmUsuarioPerfil();
            frmPerfil.Show();
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text;
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Usuario.Usuario_DNI, Usuario.Usuario_Alias, Permisos.Permiso_Categoria " +
                "FROM Usuario INNER JOIN Permisos ON Usuario.Usuario_Permisos = Permisos.Id WHERE Usuario_Nombre LIKE '%" + busqueda + "%' OR Usuario_Apellido LIKE '%" + busqueda + "%' OR Usuario_DNI LIKE '%" + busqueda + "%' ORDER BY Usuario_Apellido;"));
            dgvMatriculas.DataSource = Tabla;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmUsuarioPerfil frmPerfil = new FrmUsuarioPerfil();
            OleDbDataReader reader = claseConexion.Leer("Select * from Usuario where Id = " + dgvMatriculas.CurrentRow.Cells["UsuId"].Value.ToString() + " ;");
            
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    
                    frmPerfil.txtNombre.Text = reader.GetString(1);
                    frmPerfil.txtApellido.Text = reader.GetString(2);
                    frmPerfil.txtMail.Text = reader.GetString(3);
                    frmPerfil.txtAlias.Text = reader.GetString(4);
                    frmPerfil.cmbPermisos.SelectedValue = 0;
                    frmPerfil.txtContraseña.Text = reader.GetString(6);
                    frmPerfil.txtDNI.Text = Convert.ToString(reader.GetInt32(7));
                    frmPerfil.Show();
                }
                

            }
            else { MessageBox.Show("NOP"); }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Usuario.Usuario_DNI, Usuario.Usuario_Alias, Permisos.Permiso_Categoria " +
                "FROM Usuario INNER JOIN Permisos ON Usuario.Usuario_Permisos = Permisos.Id  where Usuario.Usuario_Baja = false;"));
            dgvMatriculas.DataSource = Tabla;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Usuario.Usuario_DNI, Usuario.Usuario_Alias, Permisos.Permiso_Categoria " +
                "FROM Usuario INNER JOIN Permisos ON Usuario.Usuario_Permisos = Permisos.Id  where Usuario.Usuario_Baja = true;"));
            dgvMatriculas.DataSource = Tabla;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT Usuario.Id, Usuario.Usuario_Nombre, Usuario.Usuario_Apellido, Usuario.Usuario_DNI, Usuario.Usuario_Alias, Permisos.Permiso_Categoria " +
                "FROM Usuario INNER JOIN Permisos ON Usuario.Usuario_Permisos = Permisos.Id ;"));
            dgvMatriculas.DataSource = Tabla;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SE DARA DE BAJA AL USUARIO : \n " +
                                dgvMatriculas.CurrentRow.Cells["UsuApellido"].Value.ToString() + " " + 
                                dgvMatriculas.CurrentRow.Cells["UsuNombre"].Value.ToString() +
                                " \n\n Desea Continuar ? \n ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                claseConexion.ABM("UPDATE Usuario SET Usuario_Baja = true WHERE Id = " + dgvMatriculas.CurrentRow.Cells["UsuId"].Value.ToString() + ";");
                MessageBox.Show("Usuario dado de baja");
            } 
        }
    }
}
