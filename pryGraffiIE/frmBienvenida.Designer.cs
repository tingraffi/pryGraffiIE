namespace pryGraffiIE
{
    partial class frmBienvenida
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
            this.components = new System.ComponentModel.Container();
            this.barraDeCarga = new System.Windows.Forms.ProgressBar();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barraDeCarga
            // 
            this.barraDeCarga.Location = new System.Drawing.Point(248, 349);
            this.barraDeCarga.Name = "barraDeCarga";
            this.barraDeCarga.Size = new System.Drawing.Size(307, 23);
            this.barraDeCarga.TabIndex = 0;
            this.barraDeCarga.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryGraffiIE.Properties.Resources.sancor_seguros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barraDeCarga);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmBienvenida_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar barraDeCarga;
        private System.Windows.Forms.Timer reloj;
    }
}