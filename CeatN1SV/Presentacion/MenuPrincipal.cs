using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logica;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        string path = "C:\\CeatN1SV\\img\\";

        public MenuPrincipal()
        {
            InitializeComponent();
        }
       
        
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblNombre.Text = UsuarioCache.Nombre;
            lblApellido.Text = UsuarioCache.Apellido;
            lblPermisos.Text = UsuarioCache.Permisos;
            
        }
        

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Cerrar sesion ?","Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes){
                this.Close();
            }

        }

        private void btnNuevaMatricula_Click(object sender, EventArgs e)
        {
            
            vaciarTAG();
            Button boton = (Button)sender;
            boton.Tag = "activo";
            btnDefault();
            FormHijo(new FrmNuevaMat());
        }

        private void btnVerMatriculas_Click(object sender, EventArgs e)
        {
            
            vaciarTAG();

            Button boton = (Button)sender;
            boton.Tag = "activo";
            btnDefault();
            FormHijo(new FrmVerMat());
        }

        private void btnEdtiarMatriculas_Click(object sender, EventArgs e)
        {
            
            vaciarTAG();
            Button boton = (Button)sender;
            boton.Tag = "activo";
            btnDefault();
            FormHijo(new FrmEditarMat());
            

        }

        private void btnBajaMatricula_Click(object sender, EventArgs e)
        {
        
            vaciarTAG();
            Button boton = (Button)sender;
            boton.Tag = "activo";
            btnDefault();
            FormHijo(new FrmBajaMat());
            
        }


       
        private void btnUsuario_Click(object sender, EventArgs e)
        {
         
            vaciarTAG();
            Button boton = (Button)sender;
            boton.Tag = "activo";
            btnDefault();
            FormHijo(new FrmUsuario());
        }






        /******************************
         * FUNCIONES diseño
         * ****************************/


        private void btn_MouseLeave(object sender, EventArgs e)
        {
            
            Button boton = (Button)sender;

            if(boton.Tag!= "activo"){
            boton.ForeColor = Color.Black;
            boton.BackColor = Color.White;
            if (boton.Name!= "btnSalir")boton.Image = Image.FromFile(path + boton.Name + "A.png");
            boton.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            
            Button boton = (Button)sender;
           
            boton.ImageAlign = ContentAlignment.MiddleCenter;
            if (boton.Name != "btnSalir")
            {
                boton.Image = Image.FromFile(path + boton.Name + "B.png");
                boton.BackColor = Color.FromArgb(123, 227, 227);
            }
            else { boton.BackColor = Color.MediumPurple; }
            
            boton.ForeColor = Color.FromArgb(254, 255, 255);
            
        }

        public void vaciarTAG()
        {
            foreach (Control control in pnlMenu.Controls)
            {
                if (control is Button)
                {
                    if (((Button)control).Name != "btnSalir")
                    {
                        ((Button)control).Tag = " ";
                    }
                }
            }
        }


        public void btnDefault()
        {
            foreach (Control control in pnlMenu.Controls)
            {
                if (control is Button)
                {
                    if (((Button)control).Name != "btnSalir" && ((Button)control).Tag != "activo")//da problemas pero funciona-no borrar-jon
                    {
                        ((Button)control).ForeColor = Color.Black;
                        ((Button)control).BackColor = Color.FromArgb(254, 255, 255);
                        ((Button)control).Image = Image.FromFile(path + ((Button)control).Name + "A.png");
                        ((Button)control).ImageAlign = ContentAlignment.MiddleLeft;
                    }

                }
            }
        }
        
        //cambiade form
        private Form formActivo = null;
        private void FormHijo(Form formHijo)
        {
            if (formActivo != null) formActivo.Close();
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formHijo);
            pnlContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPermisos_Click(object sender, EventArgs e)
        {

        }






       

        /************************
         *  FUNCIONES OBJETOS
         *  *******************/
        //UsuarioCache usu = new UsuarioCache();
        //private void UserData_Load()
        //{
            
        //    lblNombre.Text = usu.Nombre;
        //    lblApellido.Text = usu.Apellido;
        //    lblPermisos.Text = usu.Permisos;
            
        //}

    }
}
