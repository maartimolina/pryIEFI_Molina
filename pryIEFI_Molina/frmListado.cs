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
    public partial class frmListado : Form
    {
        string[,] matriz;
        string varOperacion;
        public frmListado(string varoperacion, string[,]matriz)
        {
            InitializeComponent();
            
            if (varoperacion=="Productos")
            {
                
                this.Text = "Listado de Productos";

                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    if (matriz[f,0]!= null)
                    {
                        lstProductos.Items.Add("Producto " + (f, +1).ToString());
                        lstProductos.Items.Add(" ID: " + matriz[f, 0] + " Nombre: " + matriz[f, 1] + " Fecha: " + matriz[f, 2]);
                    }
                }
            }
            else
            {

                if (varoperacion=="Ventas")
                {
                    this.Text = "Listado de Ventas";
                    for (int f = 0; f < matriz.GetLength(0); f++)
                    {
                        if (matriz[f, 0] != null)
                        {
                            lstVentas.Items.Add("Ventas " + (f, +1).ToString());
                            lstVentas.Items.Add(" ID: " + matriz[f, 0] + " Producto: " + matriz[f, 1] + " Cantidad: " + matriz[f, 2] + " Fecha:" + matriz[f, 3]);
                        }
                    }
                }

            }
        }

        public frmListado(string[,] producto)
        {
            
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVolverProductos_Click(object sender, EventArgs e)
        {
            frmCargarProductos frmCargarProductos = new frmCargarProductos();
            frmCargarProductos.ShowDialog();   
            this.Hide();
        }

        private void btnVolverVentas_Click(object sender, EventArgs e)
        {
            frmCargarVentas frmCargarVentas = new frmCargarVentas();    
            frmCargarVentas.ShowDialog();
            this.Hide();
        }
    }
}
