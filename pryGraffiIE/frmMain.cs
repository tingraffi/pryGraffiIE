using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGraffiIE
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void registroDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargaProveedores frmCargaProveedores = new frmCargaProveedores();
            frmCargaProveedores.ShowDialog();
        }

        private void verListaDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProveedorSeguro frmRegistroProveedorSeguro = new frmRegistroProveedorSeguro();
            frmRegistroProveedorSeguro.ShowDialog();
        }
    }
}
