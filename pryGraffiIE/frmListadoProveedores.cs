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
    public partial class frmListadoProveedores : Form
    {
        public frmListadoProveedores()
        {
            InitializeComponent();
        }

        private void frmListadoProveedores_Load(object sender, EventArgs e)
        {
            // = new es instanciar un objeto de una clase
            StreamReader leerArchivo = new StreamReader("datosproveedores.txt");

            while (!leerArchivo.EndOfStream)
            {
                lblMostrar.Text += leerArchivo.ReadLine();
            }

            leerArchivo.Close();

            
        }
    }
}
