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
    public partial class frmCargarVentas : Form
    {
        string[,] matrizVentas = new string[20, 4];
        int indiceFila=0;
        public frmCargarVentas()
        {
            InitializeComponent();
        }

        private void frmCargarVentas_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string varID, varProducto;
            int varCantidad;
            string varFecha = dtpFecha.Value.ToString("dd/MM/yyyy");
            varID = txtID.Text; 
            varProducto = txtProducto.Text;
            varCantidad =  Convert.ToInt32(nudCantidad.Value);
           
            matrizVentas[indiceFila, 0] = varID;
            matrizVentas[indiceFila, 1] = varProducto;
            matrizVentas[indiceFila, 2] = varCantidad.ToString();
            matrizVentas[indiceFila, 3] = varFecha;
            MessageBox.Show(matrizVentas[indiceFila, 1] + "Se agrego correctamente.");
            indiceFila++;

            dgvConsulta.Rows.Clear();
            for (int f = 0; f < matrizVentas.GetLength(0); f++)
            {
                dgvConsulta.Rows.Add(matrizVentas[f, 0], matrizVentas[f, 1], matrizVentas[f, 2], matrizVentas[f,3]);
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
            frmListado ventanaListado = new frmListado("Ventas",matrizVentas);
            ventanaListado.ShowDialog();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvConsulta.Rows.Clear();
            string varProducto;
            varProducto = txtProducto.Text;
            
            varProducto = txtFiltrar.Text;
            if (optCantidad.Checked)
            {
                for (int f = 0; f < matrizVentas.GetLength(0); f++)
                {
                    if (matrizVentas[f, 2] != null && int.Parse(matrizVentas[f, 2]) > 5)
                    {
                        dgvConsulta.Rows.Add(matrizVentas[f, 0], matrizVentas[f, 1], matrizVentas[f, 2], matrizVentas[f, 3]);
                    }
                }
            }
            else if (optProducto.Checked)
            {
                for (int f = 0; f < matrizVentas.GetLength(0); f++)
                {
                    if (matrizVentas[f, 1] != null && matrizVentas[f, 1] == varProducto)
                    {
                        dgvConsulta.Rows.Add(matrizVentas[f, 0], matrizVentas[f, 1], matrizVentas[f, 2], matrizVentas[f, 3]);
                    }
                }
            }
        }
    }
}
