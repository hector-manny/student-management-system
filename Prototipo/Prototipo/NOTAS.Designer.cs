namespace Prototipo
{
    partial class NOTAS
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
            this.label17 = new System.Windows.Forms.Label();
            this.dgvnotas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtmateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 19);
            this.label17.TabIndex = 60;
            this.label17.Text = "Seleccionar Grado";
            // 
            // dgvnotas
            // 
            this.dgvnotas.AllowUserToAddRows = false;
            this.dgvnotas.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvnotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnotas.Location = new System.Drawing.Point(39, 279);
            this.dgvnotas.Name = "dgvnotas";
            this.dgvnotas.Size = new System.Drawing.Size(883, 255);
            this.dgvnotas.TabIndex = 59;
            this.dgvnotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnotas_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtmateria);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtbuscar);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Location = new System.Drawing.Point(308, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 99);
            this.panel1.TabIndex = 58;
            // 
            // txtmateria
            // 
            this.txtmateria.FormattingEnabled = true;
            this.txtmateria.Items.AddRange(new object[] {
            "Matematica",
            "Sociales",
            "Lenguaje",
            "Ingles",
            "Ciencias"});
            this.txtmateria.Location = new System.Drawing.Point(193, 57);
            this.txtmateria.Name = "txtmateria";
            this.txtmateria.Size = new System.Drawing.Size(130, 21);
            this.txtmateria.TabIndex = 64;
            this.txtmateria.SelectedIndexChanged += new System.EventHandler(this.txtmateria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "Seleccionar Materia";
            // 
            // txtbuscar
            // 
            this.txtbuscar.FormattingEnabled = true;
            this.txtbuscar.Items.AddRange(new object[] {
            "Primer Grado",
            "Segundo Grado",
            "Tercer Grado",
            "Cuarto Grado",
            "Quinto Grado",
            "Sexto Grado ",
            "Septimo Grado",
            "Octavo Grado",
            "Noveno Grado"});
            this.txtbuscar.Location = new System.Drawing.Point(193, 30);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(130, 21);
            this.txtbuscar.TabIndex = 62;
            this.txtbuscar.SelectedIndexChanged += new System.EventHandler(this.txtbuscar_SelectedIndexChanged);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(401, 233);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(148, 20);
            this.txtnombre.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(776, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 62;
            this.button1.Text = "Imprimir Nota";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 63;
            this.label2.Text = "NIE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtnie
            // 
            this.txtnie.Enabled = false;
            this.txtnie.Location = new System.Drawing.Point(604, 235);
            this.txtnie.Name = "txtnie";
            this.txtnie.ReadOnly = true;
            this.txtnie.Size = new System.Drawing.Size(118, 20);
            this.txtnie.TabIndex = 64;
            // 
            // NOTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 569);
            this.Controls.Add(this.txtnie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvnotas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NOTAS";
            this.Text = "NOTAS";
            this.Load += new System.EventHandler(this.NOTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridView dgvnotas;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtbuscar;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnie;
        private System.Windows.Forms.ComboBox txtmateria;
        private System.Windows.Forms.Label label3;
    }
}