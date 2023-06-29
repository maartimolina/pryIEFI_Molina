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
    public partial class frmCargarProductos : Form
    {
        string[,] matrizProductos = new string[20, 3];
        int indiceFila = 0;
        public frmCargarProductos()
        {
            InitializeComponent();
        }

        private void Registro_Click(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string varID, varNombre;
            string varFecha = dtpFecha.Value.ToString("dd/MM/yyyy");
            varID = txtID.Text;
            varNombre=txtNombre.Text;

            matrizProductos[indiceFila,0] = varID;
            matrizProductos[indiceFila,1]= varNombre;
            matrizProductos[indiceFila, 2] = varFecha;
            MessageBox.Show(matrizProductos[indiceFila,1] + "Se agrego correctamente.");
            indiceFila++;

            dgvConsulta.Rows.Clear();
            for (int f = 0; f < matrizProductos.GetLength(0); f++)
            {
                dgvConsulta.Rows.Add(matrizProductos[f, 0], matrizProductos[f, 1], matrizProductos[f, 2]);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmBienvenida ventaBienvenida = new frmBienvenida();
            ventaBienvenida.ShowDialog();
            this.Hide();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado ventanaListado= new frmListado("Productos", matrizProductos);
            ventanaListado.ShowDialog();

        }

        private void frmCargarProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
