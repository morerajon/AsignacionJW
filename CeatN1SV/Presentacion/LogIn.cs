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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }
        
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.DimGray;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        Usuario usu = new Usuario();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario" || txtContra.Text != "Contraseña") 
            {
                if (usu.TraeDatos(txtUsuario.Text, txtContra.Text))
                { 
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    menu.FormClosed += Logout; // Carga el metodo logot en el form menu
                    this.Hide();

                    //MessageBox.Show("abierto");
                }
                else
                {
                    msjError("Verifique los datos ingresados");
                    txtUsuario.Focus();
                }

            } else {
                msjError("Por favor ingrese los datos");
                txtUsuario.Focus();
            }

        }

        private void msjError(string msj) {
            lblErrorLogin.Text = "    " + msj;
            lblErrorLogin.Visible = true;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void Logout(object sender, FormClosedEventArgs e) {
            txtContra.Text = "Contraseña";
            txtContra.UseSystemPasswordChar = false;
            txtContra.ForeColor = Color.DimGray;
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = Color.DimGray;
            
            lblErrorLogin.Text = "";
            this.Show();
        }



    }
}
