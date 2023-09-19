using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryGraffiIE
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            reloj.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (barraDeCarga.Value == 100)
            {
                //apago el reloj
                reloj.Enabled = false;
                this.Hide();
                frmMain ventana = new frmMain();
                ventana.ShowDialog();

            }
            else
            {
                barraDeCarga.Value += 5;
            }
        }
    }
}
