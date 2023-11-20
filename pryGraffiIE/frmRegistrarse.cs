using pryEspinosaIE;
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
    public partial class frmRegistrarse : Form
    {
        public frmRegistrarse()
        {
            InitializeComponent();
        }



        clsBasedeDatos objAcceso = new clsBasedeDatos();






        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtContraseña2.Text)
            {
                objAcceso.RegistroUsuarios(txtUsuario.Text, txtContraseña.Text);
                MessageBox.Show("Usuario registrado exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblContraseña_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtContraseña2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarse_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
        }
    }
}
