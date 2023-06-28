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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            frmCargarProductos ventaCargarProductos = new frmCargarProductos();
            ventaCargarProductos.ShowDialog();
            this.Hide();
        }

        private void btnCargarVentas_Click(object sender, EventArgs e)
        {
            frmCargarVentas ventaCargarVentas = new frmCargarVentas();
            ventaCargarVentas.ShowDialog();
            this.Hide();
        }
    }
}
