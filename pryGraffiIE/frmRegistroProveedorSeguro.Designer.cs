namespace pryGraffiIE
{
    partial class frmRegistroProveedorSeguro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblContenido = new System.Windows.Forms.Label();
            this.btnNivel2 = new System.Windows.Forms.Button();
            this.btnTreeNivel1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lblContenido
            // 
            this.lblContenido.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblContenido.Location = new System.Drawing.Point(207, 76);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(270, 221);
            this.lblContenido.TabIndex = 8;
            this.lblContenido.Text = "---";
            // 
            // btnNivel2
            // 
            this.btnNivel2.Location = new System.Drawing.Point(9, 42);
            this.btnNivel2.Name = "btnNivel2";
            this.btnNivel2.Size = new System.Drawing.Size(174, 23);
            this.btnNivel2.TabIndex = 7;
            this.btnNivel2.Text = "Nivel 2 tree";
            this.btnNivel2.UseVisualStyleBackColor = true;
            this.btnNivel2.Click += new System.EventHandler(this.btnNivel2_Click_1);
            // 
            // btnTreeNivel1
            // 
            this.btnTreeNivel1.Location = new System.Drawing.Point(9, 13);
            this.btnTreeNivel1.Name = "btnTreeNivel1";
            this.btnTreeNivel1.Size = new System.Drawing.Size(174, 23);
            this.btnTreeNivel1.TabIndex = 6;
            this.btnTreeNivel1.Text = "Nivel 1 tree";
            this.btnTreeNivel1.UseVisualStyleBackColor = true;
            this.btnTreeNivel1.Click += new System.EventHandler(this.btnTreeNivel1_Click_1);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(9, 76);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(174, 221);
            this.treeView1.TabIndex = 5;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // frmRegistroProveedorSeguro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(487, 311);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.btnNivel2);
            this.Controls.Add(this.btnTreeNivel1);
            this.Controls.Add(this.treeView1);
            this.Name = "frmRegistroProveedorSeguro";
            this.Text = "Registro de Proveedores de Seguro(PAS)";
            this.Load += new System.EventHandler(this.frmRegistroProveedorSeguro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Button btnNivel2;
        private System.Windows.Forms.Button btnTreeNivel1;
        private System.Windows.Forms.TreeView treeView1;
    }
}