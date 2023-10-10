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
    public partial class frmIniciarSesion : Form
    {
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

            clsAccesoBase objAcceso = new clsAccesoBase();

        private void btnConectar_Click(object sender, EventArgs e)
        {
            objAcceso.ConectarBaseDatos();

            if (objAcceso.estadoConexion == true)
            {
                lblResultado.Text = "Conexión Activa";
                lblResultado.BackColor = Color.White;
            }
            else
            {
                lblResultado.Text = "Falla conexiòn";
                lblResultado.BackColor = Color.Black;
            }

                

            

        }

        private void frmIniciarSesion_Load(object sender, EventArgs e)
        {
                
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            objAcceso.TraerDatos();
            lblResultado.Text = objAcceso.resultadoDatos.ToString();

            objAcceso.TraerDatos(cboUsers);
        }
    }
}
