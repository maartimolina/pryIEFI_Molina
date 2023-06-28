using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEFI_Molina
{
    public partial class frmLogin : Form
    {
        string varContraseña, varUsuario;
        int varErrores;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Length >= 8)
            {
                txtContraseña.Text = txtContraseña.Text.Substring(0, 8);
                txtContraseña.SelectionStart = 8;
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            varErrores = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            varContraseña = txtContraseña.Text;
            varUsuario = txtUsuario.Text;
            if (varUsuario=="Mar")
            {
                if (varContraseña=="2004")
                {
                    frmBienvenida ventaBienvenida = new frmBienvenida();
                    ventaBienvenida.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    varErrores++;
                }
            }
            if (varUsuario=="Ana")
            {
                if (varContraseña == "1976")
                {
                    frmBienvenida ventaBienvenida = new frmBienvenida();
                    ventaBienvenida.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    varErrores++;
                }
            }
            if (varUsuario == "Percello")
            {
                if (varContraseña == "030704")
                {
                    frmBienvenida ventaBienvenida = new frmBienvenida();
                    ventaBienvenida.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    varErrores++;
                }
            }
            if (varErrores == 3)
            {
                MessageBox.Show("Demasiados intentos, se cerrará el Inicio de Sesion");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
