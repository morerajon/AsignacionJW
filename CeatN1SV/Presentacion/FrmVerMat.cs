using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Datos;
using Logica;


namespace Presentacion
{
    public partial class FrmVerMat : Form
    {
        Conexion claseConexion = new Conexion();
        DataTable Tabla = new DataTable();
        
        

        public FrmVerMat()
        {
            InitializeComponent();
        }
        
        private void FrmVerMat_Load(object sender, EventArgs e)
        {
            OleDbDataReader reader = claseConexion.Leer("SELECT Categoria_Nombre FROM Categoria");

            while (reader.Read())
            {
                cmbSeccion.Items.Add(reader["Categoria_Nombre"].ToString());
            }

            reader.Close();
            cmbSeccion.Items.Add("Todos");
           



            OleDbDataReader reader1 = claseConexion.Leer("SELECT Caracterizacion_Nombre FROM Caracterizacion");

            while (reader1.Read())
            {
                CmbCaracterizacion.Items.Add(reader1["Caracterizacion_Nombre"].ToString());
            }

            reader1.Close();

             CmbCaracterizacion.Items.Add("Todos");


            string consultaSql = @"
                SELECT
                    Alumno_Nombres as nombre,
                    Alumno_Apellidos as Apellido,
                    Alumno_Dni as DNI,
                    Alumno_Nacimiento as F_Nacimiento,
                    s.Sexo_Categoria as sexo,
                    n.Nacionalidad_Categoria as Nacionalidad,
                    Caracterizacion.Caracterizacion_Nombre as Caracterizacion,
                    Alumno_AñoAdmision as fechaDeIngreso,
                    Categoria.Categoria_Nombre as Grado

                FROM ((((Alumno a
                INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id)  
                INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id)
                INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id)
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id )  ";
            try
            {
                Tabla.Clear();
                Tabla.Load(claseConexion.Leer(consultaSql));

             
                dgvMatriculas.DataSource = Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            lblConteo.Text = Convert.ToString(dgvMatriculas.RowCount);

            // DARIO estadistica
            Estadistica Datos = new Estadistica();
            dgvAlumMatric.DataSource = Datos.AlumnosMatriculados();
            dgvAlumPorTurno.DataSource = Datos.AlumnosMatriculados();
        }
        
        string[] var  = new string[4];

      
        private void cmbSeccion_TextChanged(object sender, EventArgs e)
        {
            if (cmbSeccion.Text == "Todos")
            {
                var[0] = null;
            }
            else
            {
                var[0] = cmbSeccion.Text;
            }
          

            CargaDeTablas();
        }

        public void CargaDeTablas()
        {
            string consultaSql2 = @"
                SELECT
                    Alumno_Nombres as nombre,
                    Alumno_Apellidos as Apellido,
                    Alumno_Dni as DNI,
                    Alumno_Nacimiento as F_Nacimiento,
                    s.Sexo_Categoria as sexo,
                    n.Nacionalidad_Categoria as Nacionalidad,
                    Caracterizacion.Caracterizacion_Nombre as Caracterizacion,
                    Alumno_AñoAdmision as fechaDeIngreso,
                    Categoria.Categoria_Nombre as Grado

                FROM ((((Alumno a
                INNER JOIN Sexo s ON a.Alumno_Sexo = s.Id)  
                INNER JOIN Caracterizacion ON a.Alumno_Caracterizacion = Caracterizacion.Id)
                INNER JOIN Nacionalidad n ON a.Alumno_Nacionalidad = n.Id)
                INNER JOIN Categoria ON a.Alumno_Categoria = Categoria.Id )  
                WHERE Categoria.Categoria_Nombre LIKE '%" +
                var[0] + "%' AND s.Sexo_Categoria LIKE '%" + var[1] + "%' AND  Caracterizacion.Caracterizacion_Nombre LIKE '%" + var[2] + "%' AND  Alumno_AñoAdmision LIKE '%" + var[3] + "%' ORDER BY Alumno_Apellidos;";




            Tabla.Clear();

            Tabla.Clear();
            Tabla.Load(claseConexion.Leer(consultaSql2));
            dgvMatriculas.DataSource = Tabla;
            lblConteo.Text = Convert.ToString(dgvMatriculas.RowCount);



        }

        private void CmbSexo_TextChanged(object sender, EventArgs e)
        {
            if (CmbSexo.Text == "Todos")
            {
                var[1] = null;
            }
            else
            {
                var[1] = CmbSexo.Text;
            }
            CargaDeTablas();
        }

        private void CmbCaracterizacion_TextChanged(object sender, EventArgs e)
        {
            if (CmbCaracterizacion.Text == "Todos")
            {
                var[2] = null;
            }
            else
            {
                var[2] = CmbCaracterizacion.Text;
            }
           

            CargaDeTablas();
        }

        private void txtAñoIngreso_TextChanged(object sender, EventArgs e)
        {
            var[3] = txtAñoIngreso.Text;

            CargaDeTablas();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       

    }
}
