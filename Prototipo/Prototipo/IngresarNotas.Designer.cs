namespace Prototipo
{
    partial class IngresarNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresarNotas));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtgradodestudio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvnotas = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmaterias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttrimestre = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnie = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpromedio1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtexamentrimestral = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnotacuaderno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtactividad = new System.Windows.Forms.TextBox();
            this.txtidmateria = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(286, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contro de notas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtgradodestudio);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(152, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 129);
            this.panel1.TabIndex = 52;
            // 
            // txtgradodestudio
            // 
            this.txtgradodestudio.Location = new System.Drawing.Point(162, 84);
            this.txtgradodestudio.Name = "txtgradodestudio";
            this.txtgradodestudio.Size = new System.Drawing.Size(148, 20);
            this.txtgradodestudio.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Grado De Estudio";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(162, 31);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 20);
            this.txtnombre.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nombre";
            // 
            // dgvnotas
            // 
            this.dgvnotas.AllowUserToAddRows = false;
            this.dgvnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnotas.Location = new System.Drawing.Point(12, 362);
            this.dgvnotas.Name = "dgvnotas";
            this.dgvnotas.Size = new System.Drawing.Size(548, 240);
            this.dgvnotas.TabIndex = 53;
            this.dgvnotas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnotas_CellClick);
            this.dgvnotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnotas_CellContentClick);
            this.dgvnotas.DoubleClick += new System.EventHandler(this.dgvnotas_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtmaterias);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txttrimestre);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtnie);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtpromedio1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtexamentrimestral);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtnotacuaderno);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtactividad);
            this.panel2.Location = new System.Drawing.Point(621, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 490);
            this.panel2.TabIndex = 53;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtmaterias
            // 
            this.txtmaterias.FormattingEnabled = true;
            this.txtmaterias.Items.AddRange(new object[] {
            "Matematica",
            "Ciencias",
            "Sociales",
            "Lenguaje",
            "Ingles"});
            this.txtmaterias.Location = new System.Drawing.Point(217, 103);
            this.txtmaterias.Name = "txtmaterias";
            this.txtmaterias.Size = new System.Drawing.Size(101, 21);
            this.txtmaterias.TabIndex = 74;
            this.txtmaterias.Text = "Selecciona";
            this.txtmaterias.Leave += new System.EventHandler(this.txtmaterias_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "Materias";
            // 
            // txttrimestre
            // 
            this.txttrimestre.FormattingEnabled = true;
            this.txttrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.txttrimestre.Location = new System.Drawing.Point(217, 45);
            this.txttrimestre.Name = "txttrimestre";
            this.txttrimestre.Size = new System.Drawing.Size(101, 21);
            this.txttrimestre.TabIndex = 72;
            this.txttrimestre.Text = "Selecciona";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(158, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 53);
            this.button2.TabIndex = 71;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtnie
            // 
            this.txtnie.Location = new System.Drawing.Point(217, 153);
            this.txtnie.Name = "txtnie";
            this.txtnie.Size = new System.Drawing.Size(101, 20);
            this.txtnie.TabIndex = 68;
            this.txtnie.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 19);
            this.label7.TabIndex = 67;
            this.label7.Text = "NIE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "TRIMESTRE";
            // 
            // txtpromedio1
            // 
            this.txtpromedio1.Enabled = false;
            this.txtpromedio1.Location = new System.Drawing.Point(217, 370);
            this.txtpromedio1.Name = "txtpromedio1";
            this.txtpromedio1.Size = new System.Drawing.Size(101, 20);
            this.txtpromedio1.TabIndex = 55;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 369);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 19);
            this.label16.TabIndex = 54;
            this.label16.Text = "Promedio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Examen Trimestral";
            // 
            // txtexamentrimestral
            // 
            this.txtexamentrimestral.Location = new System.Drawing.Point(217, 300);
            this.txtexamentrimestral.Name = "txtexamentrimestral";
            this.txtexamentrimestral.Size = new System.Drawing.Size(101, 20);
            this.txtexamentrimestral.TabIndex = 29;
            this.txtexamentrimestral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1nota3_KeyPress);
            this.txtexamentrimestral.Leave += new System.EventHandler(this.txt1nota3_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nota Cuaderno";
            // 
            // txtnotacuaderno
            // 
            this.txtnotacuaderno.Location = new System.Drawing.Point(217, 252);
            this.txtnotacuaderno.Name = "txtnotacuaderno";
            this.txtnotacuaderno.Size = new System.Drawing.Size(101, 20);
            this.txtnotacuaderno.TabIndex = 27;
            this.txtnotacuaderno.TextChanged += new System.EventHandler(this.txt1nota2_TextChanged);
            this.txtnotacuaderno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1nota2_KeyPress);
            this.txtnotacuaderno.Leave += new System.EventHandler(this.txt1nota2_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Actividad";
            // 
            // txtactividad
            // 
            this.txtactividad.Location = new System.Drawing.Point(217, 201);
            this.txtactividad.Name = "txtactividad";
            this.txtactividad.Size = new System.Drawing.Size(101, 20);
            this.txtactividad.TabIndex = 23;
            this.txtactividad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtactividad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt1nota1_KeyPress);
            this.txtactividad.Leave += new System.EventHandler(this.txt1nota1_Leave);
            // 
            // txtidmateria
            // 
            this.txtidmateria.Enabled = false;
            this.txtidmateria.Location = new System.Drawing.Point(888, 14);
            this.txtidmateria.Name = "txtidmateria";
            this.txtidmateria.Size = new System.Drawing.Size(101, 20);
            this.txtidmateria.TabIndex = 70;
            this.txtidmateria.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(681, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 53);
            this.button1.TabIndex = 62;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(339, 328);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(135, 20);
            this.txtbuscar.TabIndex = 57;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(237, 328);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 19);
            this.label17.TabIndex = 56;
            this.label17.Text = "Buscar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1070, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 59;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // IngresarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1131, 657);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtidmateria);
            this.Controls.Add(this.dgvnotas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresarNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresarNotas";
            this.Load += new System.EventHandler(this.IngresarNotas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtgradodestudio;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvnotas;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtexamentrimestral;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnotacuaderno;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtactividad;
        public System.Windows.Forms.TextBox txtpromedio1;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox btnCerrar;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtnie;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtidmateria;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txttrimestre;
        private System.Windows.Forms.ComboBox txtmaterias;
        private System.Windows.Forms.Label label6;
    }
}