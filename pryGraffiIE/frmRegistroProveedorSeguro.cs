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
using System.Xml.Linq;




namespace pryGraffiIE
{
    public partial class frmRegistroProveedorSeguro : Form
    {
        public frmRegistroProveedorSeguro()
        {
            InitializeComponent();
        }

       

        private void CargarTreeView(string rutaCarpetaRaiz, string nombreCarpeta)
        {
            treeView1.Nodes.Clear();

            if (Directory.Exists(rutaCarpetaRaiz))
            {
                TreeNode nodoRaiz = new TreeNode(nombreCarpeta);
                treeView1.Nodes.Add(nodoRaiz);
                TraerSubCarpetas(rutaCarpetaRaiz, nodoRaiz);
                TraerArchivos(rutaCarpetaRaiz, nodoRaiz);
            }
        }

        private void TraerSubCarpetas(string ruta, TreeNode nodoRaiz)
        {
            try
            {
                string[] subCarpetas = Directory.GetDirectories(ruta);

                foreach (string subDirectorio in subCarpetas)
                {
                    TreeNode node = new TreeNode(Path.GetFileName(subDirectorio));
                    nodoRaiz.Nodes.Add(node);

                    
                    TraerSubCarpetas(subDirectorio, node);
                    TraerArchivos(subDirectorio, node);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void TraerArchivos(string ruta, TreeNode nodoRaiz)
        {
            string[] archivos = Directory.GetFiles(ruta);

            foreach (string archivo in archivos)
            {
                TreeNode nodoArchivo = new TreeNode(Path.GetFileName(archivo));
                nodoRaiz.Nodes.Add(nodoArchivo);
            }

        }

    
        


        private void frmRegistroProveedorSeguro_Load(object sender, EventArgs e)
        {

           

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            lblContenido.Text = "";

            try
            {
                DirectoryInfo info = new DirectoryInfo(@"../..");

                string rutaArchivo = info.FullName + "\\" + e.Node.Text;

                StreamReader lectorArchivos = new StreamReader(rutaArchivo);

                if (lectorArchivos != null)
                {
                    while (!lectorArchivos.EndOfStream)
                    {
                        lblContenido.Text += lectorArchivos.ReadLine();
                    }
                }

                lectorArchivos.Close();
            }
            catch (Exception)
            {

            }

        }

        private void btnNivel2_Click_1(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(@"../../");

            string ruta = info.FullName + "Proveedores";

            CargarTreeView(ruta, info.Name);
        }

        private void btnTreeNivel1_Click_1(object sender, EventArgs e)
        {
            
            DirectoryInfo info = new DirectoryInfo("C:\\Users\\Alumnos\\source\\repos\\pryCasaleIE\\pryCasaleIE");

            CargarTreeView(info.FullName, info.Name);
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }
    }
    }

