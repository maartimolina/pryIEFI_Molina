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
        public frmCargarVentas()
        {
            InitializeComponent();
        }

        private void frmCargarVentas_Load(object sender, EventArgs e)
        {
            frmBienvenida ventaBienvenida = new frmBienvenida();
            ventaBienvenida.ShowDialog();
            this.Hide();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
