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
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        clsBasedeDatos objAcceso = new clsBasedeDatos();

        Int32 IntentosFallidos = 0;

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (objAcceso.ValidarUsuarios(txtNombreUsuario.Text, txtContraseña.Text) == true)
            {
                frmBienvenida fb = new frmBienvenida();
                fb.ShowDialog();
                frmInicioSesion fin = new frmInicioSesion();
                fin.Close();
                IntentosFallidos = 0;
            }
            else
            {
                MessageBox.Show("El usuario o la contraseña ingresada es incorrecta");
                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                IntentosFallidos++;
                if (IntentosFallidos >= 3)
                {
                    btnIniciarSesion.Enabled = false;
                    MessageBox.Show("Alcanzó el límite máximo de intentos");
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmRegistrarse fr = new frmRegistrarse();
            fr.ShowDialog();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();
            txtContraseña.PasswordChar = '*';
        }
    }
}
