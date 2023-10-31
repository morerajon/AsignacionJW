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
    public partial class FrmEditarMat : Form
    {
        Conexion claseConexion = new Conexion();
        DataTable Tabla = new DataTable();

        public FrmEditarMat()
        {
            InitializeComponent();
        }

        private void dgvMatriculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEditarMat_Load(object sender, EventArgs e)
        {
            Tabla.Clear();
            Tabla.Load(claseConexion.Leer("SELECT * FROM Alumno"));
            dgvMatriculas.DataSource = Tabla;
        }
    }
}
