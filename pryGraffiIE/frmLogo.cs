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
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmVentasSeguros x = new frmVentasSeguros();
            x.ShowDialog();
        }

        private void frmLogo_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.logo_sancor;
        }
    }
}
