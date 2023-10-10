namespace pryGraffiIE
{
    partial class frmCargaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProveedores));
            this.lblDatos = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExpediente = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtLiquidador = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbJuzg = new System.Windows.Forms.ComboBox();
            this.cmbJurisdiccion = new System.Windows.Forms.ComboBox();
            this.cmbLiquidador = new System.Windows.Forms.ComboBox();
            this.txtJuzg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.BackColor = System.Drawing.Color.DeepPink;
            this.lblDatos.Location = new System.Drawing.Point(921, 9);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(393, 96);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Visible = false;
            this.lblDatos.Click += new System.EventHandler(this.lblDatos_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Entidad,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDatos.Location = new System.Drawing.Point(28, 197);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(842, 200);
            this.dgvDatos.TabIndex = 1;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "N*";
            this.Column1.Name = "Column1";
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apertura";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "N* Expediente";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Juzg.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jurisdicción";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Dirección";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Liquidador responsable";
            this.Column7.Name = "Column7";
            // 
            // txtExpediente
            // 
            this.txtExpediente.Location = new System.Drawing.Point(346, 137);
            this.txtExpediente.Name = "txtExpediente";
            this.txtExpediente.Size = new System.Drawing.Size(100, 20);
            this.txtExpediente.TabIndex = 3;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(134, 137);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(100, 20);
            this.txtEntidad.TabIndex = 4;
            this.txtEntidad.TextChanged += new System.EventHandler(this.txtEntidad_TextChanged);
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(240, 137);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(100, 20);
            this.txtApertura.TabIndex = 5;
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Location = new System.Drawing.Point(1085, 31);
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(100, 20);
            this.txtJurisdiccion.TabIndex = 6;
            this.txtJurisdiccion.Visible = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(664, 137);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // txtLiquidador
            // 
            this.txtLiquidador.Location = new System.Drawing.Point(1208, 31);
            this.txtLiquidador.Name = "txtLiquidador";
            this.txtLiquidador.Size = new System.Drawing.Size(100, 20);
            this.txtLiquidador.TabIndex = 8;
            this.txtLiquidador.Visible = false;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(740, 464);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 9;
            this.btnGrabar.Text = "grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(28, 137);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Entidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apertura:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "N* Expediente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Juzg:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Jurisdicción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dirección:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(767, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Liquidador responsable:";
            // 
            // cmbJuzg
            // 
            this.cmbJuzg.FormattingEnabled = true;
            this.cmbJuzg.Items.AddRange(new object[] {
            "Comercial N° 2, Secretaría N° 3",
            "Civil y Comercial, 6ta. Nominación",
            "Comercial N° 19, Secretaría N° 38",
            "Comercial N° 16, Secretaría N° 31",
            "Comercial N° 24, Secretaría N° 47",
            "Comercial N° 3, Secretaría N° 5",
            "Comercial N° 8, Secretaría N° 15",
            "Comercial N° 15, Secretaría N° 30",
            "Comercial N° 5, Secretaría N° 9",
            "Civil y Comercial N° 9, sec. N° 8",
            "Comercial N° 26, Secretaría 52",
            "Comercial N° 24, Secretaría N° 48",
            "Comercial N° 1, Secretaría N° 1",
            "Comercial N° 8, Secretaría N° 15",
            "Comercial N° 25, Secretaría N° 50",
            "Comercial N° 5, Secretaría N° 10",
            "Comercial N° 9, Secretaría N° 18",
            "Comercial N° 16, Secretaría N° 31",
            "Comercial N° 4, Secretaría N° 8",
            "Comercial N° 12, Secretaría N° 24",
            "Comercial Nº 14, Secretaría N° 28",
            "Comercial Nº 26 Secretaría N° 51",
            "Comercial Nº 5, Secretaría N° 10",
            "Comercial Nº 1, Secretaría N° 2",
            "Civil Y Comercial de la 2da. Nom.",
            "Comercial N° 14, Secretaría N° 28",
            "Comercial N° 13, Secretaría N° 25",
            "Comercial N° 1, Secretaría N° 2",
            "Juzg.1° Inst. Civil y Comercial 4, Distrito Judicial Centro",
            "Civil y Comercial N° 5, Sec. N° 2",
            "Comercial N° 6, Secretaría N° 12",
            "Comercial N° 7, Secretaría N° 13",
            "Civil y Comercial N° 26, Sec. N° 52",
            "Civil y Comercial N° 5",
            "Comercial N° 8, Secretaría N° 16",
            "Civil y Comercial 9na. Nominación",
            "Comercial N° 17, Secretaría N° 33",
            "Comercial N° 15, Secretaría N° 30",
            "Civil y Comercial N° 1",
            "Civil y Comercial 7ma nominación",
            "Comercial N° 8, Secretaría N° 15",
            "Civil y Comercial N° 2, Sec. N° 3",
            "Comercial N° 13, Secretaría N° 26",
            "Comercial N° 21, Secretaría 41",
            "Civil y Comerial de la 2a nom., Secretaría Nº 3",
            "Comercial N° 25, Secretaría N° 49",
            "Comercial N° 23, Secretaría N° 45",
            "Civil y Comercial N° 2, Sec. Unica",
            "Civil y Comercial N° 7",
            "Comercial N° 9, Secretaría N° 17",
            "Comercial N° 13, Secretaría 25",
            "Comercial N° 8, Secretaría N° 16",
            "Comercial N° 23, Secretaría N° 46",
            "Comercial N° 1, Secretaría N° 2",
            "Comercial N° 10, Secretaría N° 20",
            "Juzg. de distrito de la 8a nominación",
            "Comercial N° 26, Secretaría 51",
            "Civil y Comercial 13 nominacion",
            "Civil Y Comercial de la 10° Nom.",
            "Comercial N° 2, Secretaría N° 4",
            "Comercial N° 22, Secretaría N° 43",
            "Comercial N° 1, Secretaría N° 1",
            "Comercial N° 3, Secretaría N° 6",
            "Comercial N° 26, Secretaría 51",
            "Comercial N° 2, Secretaría N° 3",
            "Comercial N° 19, Secretaría 38",
            "Civil y Com 7ma nom., Sec.N° 4",
            "Comercial N° 16, Secretaría N° 32",
            "Comercial N° 6, Secretaría N° 11",
            "Concursos y Registro N° 2",
            "Comercial N° 3, Secretaría N° 5",
            "Comercial Nº 8, Secretaría Nº 16",
            "Juzg. de la 1° Inst.de 26 Nominación en lo Civil y Comercial de Concursos y Socie" +
                "dades N° 2",
            "Civil y Comercial 4ta nominación",
            "Comercial N° 1, Secretaría N° 2",
            "Comercial N° 25, Secretaría N° 49",
            "Comercial N° 9, Secretaría N° 18",
            "Comercial N° 4, Secretaría N° 7",
            "Comercial N° 9, Secretaría 18",
            "Comercial N° 7, Secretaría N° 14",
            "Comercial N° 16, Secretaría N° 31",
            "1ª Inst.Civily Com.Dist.15ª Nom.",
            "Civil y Comercial 10ma. Nominación",
            "Comercial N° 19, Secretaría 37",
            "Comercial N° 17, Secretaría N° 33",
            "Comercial N° 16, Secretaría N° 32",
            "Comercial N° 6, Secretaría N° 12",
            "N° 2 de Concursos",
            "Comercial Nº 13, Secretaría N° 25",
            "Comercial N° 9, Secretaría N° 17",
            "Comercial N° 7, Secretaría N° 13",
            "Comercial N° 9, Secretaría N° 17",
            "Comercial N° 10, Secretaría N° 19",
            "Civil y Comercial N° 7",
            "Civil y Comercial N° 1, Sec. N° 2",
            "Civil y Comercial N° 1",
            "Civil y Comercial N° 1",
            "Civil y Comercial N° 1",
            "Comercial N° 1, Secretaría N° 1",
            "Civil y Comercial 6ta Nominación",
            "Comercial N° 2, Secretaría N° 4",
            "Civil y Comercial N° 6, Secretaría 4",
            "Comercial N° 22, Sec. N° 44",
            "Comercial N° 12, Secretaría N° 24",
            "Comercial N° 13, Secretaría N° 26",
            "Comercial N° 1, Secretaría N° 2",
            "Comercial N° 8, Secretaría N° 16",
            "Comercial N° 7, Secretaría N° 14",
            "Comercial N° 22, Secretaría N° 44",
            "Comercial N° 4, Secretaría N° 8",
            "Comercial N° 16, Secretaría N° 32",
            "Comercial N° 18, Secretaría N° 35",
            "Comercial N° 15, Secretaría N° 29",
            "Comercial N° 8, Secretaría N° 16",
            "Comercial N° 19, Secretaría N° 38",
            "Comercial N° 1, Secretaría N° 2",
            "Comercial N° 1, Secretaría N° 2",
            "Comercial N° 10, Secretaría N° 19",
            "Civil y Comercial N° 3",
            "Comercial N° 25, Secretaría N° 49",
            "Civil y Comercial 13 nominacion",
            "Comercial N° 15, Secretaría N° 29",
            "Comercial N° 24, Secretaría N° 48",
            "Comercial N° 4, Secretaría N° 8",
            "Comercial N° 4, Secretaría N° 7",
            "Civil, Comercial y Especial N° 1",
            "Comercial N° 23, Secretaría N° 45",
            "Comercial N° 25, Secretaría N° 50",
            "Comercial N° 26, Secretaría N° 52",
            "Civil y Comercial 2 Nominación",
            "Civil y Com. 7 Nom., N° 4, Sec. 13",
            "Civil y Comercial 8va. nominación",
            "Comercial N° 22, Secretaría N° 44",
            "Comercial N° 15, Secretaría N° 29",
            "Comercial N° 25, Secretaría N° 50",
            "Comercial N° 7, Secretaría N° 14",
            "Comercial N° 20, Secretaría N° 39",
            "Comercial N° 5, Secretaría N° 9",
            "Civil y Comercial 3ra. nominación",
            "Comercial N° 3, Secretaría N° 5",
            "Comercial N° 26, Secretaría N° 52",
            "Civil y Comercial de la 2a Nominación",
            "Comercial N° 26, Secretaría N° 52",
            "Civil y Comercial 13 Nominación",
            "Comercial N° 9, Secretaría N° 17",
            "Comercial N° 2, Secretaría N° 4",
            "Civil y Comercial N° 4",
            "Comercial 23, Secretaría 45",
            "Comercial 16, Secretaría 32",
            "Comercial 13, Secretaría 26",
            "Comercial 18, Secretaría 35",
            "Comercial Nº 9, Secretaría 18",
            "Comercial 17, Secretaría 33",
            "Juzg. 1º Dist. De la 4ª Nom.",
            "Comercial 8, Secretaría 16",
            "Comercial 14, Secretaria 27",
            "Comercial 31, Secretaría 61"});
            this.cmbJuzg.Location = new System.Drawing.Point(452, 137);
            this.cmbJuzg.Name = "cmbJuzg";
            this.cmbJuzg.Size = new System.Drawing.Size(100, 21);
            this.cmbJuzg.TabIndex = 19;
            // 
            // cmbJurisdiccion
            // 
            this.cmbJurisdiccion.FormattingEnabled = true;
            this.cmbJurisdiccion.Items.AddRange(new object[] {
            "CABA",
            "Resistencia-Chaco",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Mercedes- Pcia. de Bs. As.",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Río Cuarto-Córdoba",
            "CABA",
            "CABA",
            "CABA",
            "Salta",
            "Bahía Blanca-Pcia. de Bs. As.",
            "CABA",
            "CABA",
            "Córdoba",
            "Lomas de Zamora-Pcia. de Bs. As.",
            "CABA",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "Lomas de Zamora-Pcia. de Bs. As.",
            "Rosario-Santa Fe",
            "CABA",
            "Chaco",
            "CABA",
            "CABA",
            "Villa María - Córdoba",
            "CABA",
            "CABA",
            "Tandil-Pcia. de Bs. As.",
            "Tucumán",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Rosario-Santa Fe",
            "CABA",
            "Rosario-Santa Fe",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Córdoba",
            "CABA",
            "CABA",
            "Mendoza",
            "CABA",
            "CABA",
            "Córdoba",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Rosario-Santa Fe",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Mendoza",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "La Plata",
            "Tres Arroyos-Bs.As.",
            "Tres Arroyos-Bs.As.",
            "Tres Arroyos-Bs.As.",
            "T. Lauquen-Bs. As.",
            "CABA",
            "Salta",
            "CABA",
            "Bahía Blanca-Pcia. de Bs. As.",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Pergamino-Bs. As.",
            "CABA",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "San Juan",
            "CABA",
            "CABA",
            "CABA",
            "Rosario-Santa Fe",
            "Córdoba",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "Venado Tuerto-Santa Fe",
            "CABA",
            "Rosario-Santa Fe",
            "CABA",
            "CABA",
            "La Matanza - Pcia. de Bs.As.",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "CABA",
            "Rafaela - Santa Fe",
            "CABA",
            "CABA",
            "Juzgado es Montevideo 546, piso 7º"});
            this.cmbJurisdiccion.Location = new System.Drawing.Point(558, 137);
            this.cmbJurisdiccion.Name = "cmbJurisdiccion";
            this.cmbJurisdiccion.Size = new System.Drawing.Size(100, 21);
            this.cmbJurisdiccion.TabIndex = 20;
            // 
            // cmbLiquidador
            // 
            this.cmbLiquidador.FormattingEnabled = true;
            this.cmbLiquidador.Items.AddRange(new object[] {
            "Dra. María Cristina Ubbriaco",
            "Sr. Ricardo Crosetto",
            "Dra. María Alejandra Spagnolo",
            "Dra. María Cristina Ubbriaco",
            "Cont. Orlando Marcelo Suarez",
            "Cont. Orlando Marcelo Suarez",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Martín Riera ",
            "Dra. Alicia Nilda Sturla",
            "Cont. Edgardo Gustavo Silva",
            "Cont. Orlando Marcelo Suarez",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Claudia Marcela Pariente",
            "Cont. Héctor Jorge García",
            "Dra. Claudia Marcela Pariente",
            "Dra. María Cristina Ubbriaco",
            "Cont. Orlando Marcelo Suarez",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. Claudia Marcela Pariente",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. María Cristina Ubbriaco",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. Verónica Ortíz Auger",
            "Cont. Edgardo Gustavo Silva",
            "Dra. María Cristina Ubbriaco",
            "Dra. Claudia Marcela Pariente",
            "Cont. Orlando Marcelo Suarez",
            "Dra. Claudia Marcela Pariente",
            "Dra. María Cristina Ubbriaco",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Martín Riera ",
            "Cont. Orlando Marcelo Suarez",
            "Dra. Alicia Nilda Sturla",
            "Dra. Alicia Nilda Sturla",
            "Dra. Andrea Susana Rojas ",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Oscar Guillermo Carreras",
            "Cont. Héctor Jorge García",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Andrea Susana Rojas ",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Martín Riera",
            "Dra. María Cristina Ubbriaco",
            "Dra. María Cristina Ubbriaco",
            "Sr. Ricardo Crosetto",
            "Dr. Luis Petrate Arguello",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Claudia Marcela Pariente",
            "Cont. Héctor Jorge García",
            "Cont. Héctor Jorge García",
            "Dr. Martín Riera",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Martín Riera ",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. María Cristina Ubbriaco",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Claudia Marcela Pariente",
            "Cont. Orlando Marcelo Suarez",
            "Dra. María Cristina Ubbriaco",
            "Cont. Héctor Jorge García",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Ezequiel Cará",
            "Dra. Alicia Nilda Sturla",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Claudia Marcela Pariente",
            "Cont. Edgardo Gustavo Silva",
            "Dra. Andrea Susana Rojas ",
            "Dra. Alicia Nilda Sturla",
            "Dra. Alicia Nilda Sturla",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Claudia Marcela Pariente",
            "Dra. María Cristina Ubbriaco",
            "Dra. Alicia Nilda Sturla",
            "Dra. María Cristina Ubbriaco",
            "Dra. Andrea Susana Rojas ",
            "Dra. María Cristina Ubbriaco",
            "Dra. María Cristina Ubbriaco",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Ezequiel Cará",
            "Dr. Luis Petrate Arguello",
            "Dra. María Cristina Ubbriaco",
            "Dra. María Alejandra Spagnolo",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Carlos Eduardo Sercovich",
            "Cont. Héctor Jorge García",
            "Dr. Carlos Eduardo Sercovich",
            "Dra. Verónica Ortíz Auger",
            "Dra. María Cristina Ubbriaco",
            "Dra. Claudia Marcela Pariente",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Oscar Guillermo Carreras",
            "Cont. Edgardo Gustavo Silva",
            "Cont. Edgardo Gustavo Silva",
            "Cont. Héctor Jorge García",
            "Cont. Héctor Jorge García",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Ezequiel Cará",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Oscar Guillermo Carreras",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Andrea Susana Rojas ",
            "Dr. Luis Petrate Arguello",
            "Dra. Claudia Marcela Pariente",
            "Dr. Luis Petrate Arguello",
            "Cont. Héctor Jorge García",
            "Dr. Luis Petrate Arguello",
            "Cont. Orlando Marcelo Suarez",
            "Dra. Andrea Susana Rojas ",
            "Dr. Luis Petrate Arguello",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Claudia Marcela Pariente",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Cont. Héctor Jorge García",
            "Dra. María Cristina Ubbriaco",
            "Dr. Oscar Guillermo Carreras",
            "Cont. Roberto Falvo",
            "Dra. María Cristina Ubbriaco",
            "Cont. Héctor Jorge García",
            "Dr. Luis Petrate Arguello",
            "Dra. María Cristina Ubbriaco",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Alicia Nilda Sturla",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Claudia Marcela Pariente",
            "Dr. Luis Petrate Arguello",
            "Cont. Héctor Jorge García",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Ezequiel Cará",
            "Dr. Domingo Gómez Bisgarra",
            "Dra. Gabriela Inés Trapaglia",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Carlos Eduardo Sercovich",
            "Dr. Oscar Guillermo Carreras",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. Gabriela Inés Trapaglia",
            "Dra. María Mendía",
            "Dr. Ezequiel Cará",
            "Dra. Alicia Nilda Sturla",
            "Cont. Roberto Falvo",
            "Dra. María Cristina Ubbriaco",
            "Cont. Héctor Jorge García",
            "Dres. María Mendía y Martín Riera",
            "Dra. Alicia Nilda Sturla",
            "Dra. Gabriela Inés Trapaglia",
            "Cont. Edgardo Gustavo Silva",
            "Dr. Domingo Gómez Bisgarra",
            "Dres. María Mendía y Martín Riera",
            "Dras. Andrea Rojas y Claudia Pariente"});
            this.cmbLiquidador.Location = new System.Drawing.Point(770, 137);
            this.cmbLiquidador.Name = "cmbLiquidador";
            this.cmbLiquidador.Size = new System.Drawing.Size(100, 21);
            this.cmbLiquidador.TabIndex = 21;
            // 
            // txtJuzg
            // 
            this.txtJuzg.Location = new System.Drawing.Point(903, 31);
            this.txtJuzg.Name = "txtJuzg";
            this.txtJuzg.Size = new System.Drawing.Size(100, 20);
            this.txtJuzg.TabIndex = 2;
            this.txtJuzg.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(24, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Doble click en la grilla para mostrar";
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(664, 464);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 24;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // frmCargaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(890, 506);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbLiquidador);
            this.Controls.Add(this.cmbJurisdiccion);
            this.Controls.Add(this.cmbJuzg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtLiquidador);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtJurisdiccion);
            this.Controls.Add(this.txtApertura);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.txtExpediente);
            this.Controls.Add(this.txtJuzg);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lblDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaProveedores";
            this.Text = "Carga de Proveedores";
            this.Load += new System.EventHandler(this.frmCargaProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtExpediente;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtJurisdiccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtLiquidador;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbJuzg;
        private System.Windows.Forms.ComboBox cmbJurisdiccion;
        private System.Windows.Forms.ComboBox cmbLiquidador;
        private System.Windows.Forms.TextBox txtJuzg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Limpiar;
    }
}