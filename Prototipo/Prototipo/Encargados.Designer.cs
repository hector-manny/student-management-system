namespace Prototipo
{
    partial class Encargados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtlugar = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtnie = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btncrearbase = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtmunicipio = new System.Windows.Forms.ComboBox();
            this.txtdepartamento = new System.Windows.Forms.ComboBox();
            this.txttomo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtposeepartida = new System.Windows.Forms.ComboBox();
            this.txtzona = new System.Windows.Forms.ComboBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumeropartida = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtsabeleer = new System.Windows.Forms.ComboBox();
            this.txtgradodeestudio = new System.Windows.Forms.ComboBox();
            this.txtnombreen = new System.Windows.Forms.TextBox();
            this.txtparentesco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.txtlugar);
            this.panel1.Controls.Add(this.txtfecha);
            this.panel1.Controls.Add(this.txtnie);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtlibro);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(500, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 221);
            this.panel1.TabIndex = 55;
            // 
            // txtlugar
            // 
            this.txtlugar.Location = new System.Drawing.Point(182, 70);
            this.txtlugar.Name = "txtlugar";
            this.txtlugar.Size = new System.Drawing.Size(163, 20);
            this.txtlugar.TabIndex = 59;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(174, 129);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(200, 20);
            this.txtfecha.TabIndex = 58;
            // 
            // txtnie
            // 
            this.txtnie.Enabled = false;
            this.txtnie.Location = new System.Drawing.Point(182, 174);
            this.txtnie.Name = "txtnie";
            this.txtnie.Size = new System.Drawing.Size(163, 20);
            this.txtnie.TabIndex = 56;
            this.txtnie.TextChanged += new System.EventHandler(this.txtnie_TextChanged_1);
            this.txtnie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnie_KeyPress);
            this.txtnie.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtnie_Layout);
            this.txtnie.Leave += new System.EventHandler(this.txtnie_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(4, 174);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 19);
            this.label21.TabIndex = 55;
            this.label21.Text = "NIE";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(-4, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 19);
            this.label20.TabIndex = 53;
            this.label20.Text = "Fecha de nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 19);
            this.label11.TabIndex = 51;
            this.label11.Text = "Lugar de nacimiento";
            // 
            // txtlibro
            // 
            this.txtlibro.Location = new System.Drawing.Point(182, 29);
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(163, 20);
            this.txtlibro.TabIndex = 23;
            this.txtlibro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtlibro_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Libro";
            // 
            // btncrearbase
            // 
            this.btncrearbase.BackColor = System.Drawing.Color.DimGray;
            this.btncrearbase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btncrearbase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrearbase.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrearbase.ForeColor = System.Drawing.Color.Black;
            this.btncrearbase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrearbase.Location = new System.Drawing.Point(109, 479);
            this.btncrearbase.Name = "btncrearbase";
            this.btncrearbase.Size = new System.Drawing.Size(178, 53);
            this.btncrearbase.TabIndex = 54;
            this.btncrearbase.Text = "Guardar Base";
            this.btncrearbase.UseVisualStyleBackColor = false;
            this.btncrearbase.Click += new System.EventHandler(this.btncrearbase_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.txtmunicipio);
            this.panel3.Controls.Add(this.txtdepartamento);
            this.panel3.Controls.Add(this.txttomo);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txtfolio);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtposeepartida);
            this.panel3.Controls.Add(this.txtzona);
            this.panel3.Controls.Add(this.txtcomplemento);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtnumeropartida);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 368);
            this.panel3.TabIndex = 56;
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.FormattingEnabled = true;
            this.txtmunicipio.Location = new System.Drawing.Point(204, 67);
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(109, 27);
            this.txtmunicipio.TabIndex = 58;
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.FormattingEnabled = true;
            this.txtdepartamento.Items.AddRange(new object[] {
            "Ahuachapán",
            "Santa Ana",
            "Sonsonate",
            "Chalatenango",
            "Cuscatlán",
            "San Salvador",
            "La Libertad",
            "San Vicente",
            "Cabañas",
            "La Paz",
            "Usulután",
            "San Miguel",
            "Morazán",
            "La Unión"});
            this.txtdepartamento.Location = new System.Drawing.Point(204, 16);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(109, 27);
            this.txtdepartamento.TabIndex = 58;
            this.txtdepartamento.Leave += new System.EventHandler(this.txtdepartamento_Leave);
            // 
            // txttomo
            // 
            this.txttomo.Location = new System.Drawing.Point(204, 314);
            this.txttomo.Name = "txttomo";
            this.txttomo.Size = new System.Drawing.Size(109, 24);
            this.txttomo.TabIndex = 63;
            this.txttomo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttomo_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 314);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 19);
            this.label19.TabIndex = 64;
            this.label19.Text = "Tomo";
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(204, 278);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(109, 24);
            this.txtfolio.TabIndex = 61;
            this.txtfolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfolio_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 278);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 19);
            this.label18.TabIndex = 62;
            this.label18.Text = "Folio";
            // 
            // txtposeepartida
            // 
            this.txtposeepartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtposeepartida.FormattingEnabled = true;
            this.txtposeepartida.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.txtposeepartida.Location = new System.Drawing.Point(204, 200);
            this.txtposeepartida.Name = "txtposeepartida";
            this.txtposeepartida.Size = new System.Drawing.Size(109, 20);
            this.txtposeepartida.TabIndex = 60;
            this.txtposeepartida.Text = "Selecciona";
            // 
            // txtzona
            // 
            this.txtzona.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzona.FormattingEnabled = true;
            this.txtzona.Items.AddRange(new object[] {
            "Rural",
            "Urbana"});
            this.txtzona.Location = new System.Drawing.Point(204, 112);
            this.txtzona.Name = "txtzona";
            this.txtzona.Size = new System.Drawing.Size(109, 20);
            this.txtzona.TabIndex = 56;
            this.txtzona.Text = "Selecciona";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(204, 158);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(109, 24);
            this.txtcomplemento.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "Complemento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 19);
            this.label17.TabIndex = 56;
            this.label17.Text = "Municipio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Poseè Partida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Departamento";
            // 
            // txtnumeropartida
            // 
            this.txtnumeropartida.Location = new System.Drawing.Point(204, 246);
            this.txtnumeropartida.Name = "txtnumeropartida";
            this.txtnumeropartida.Size = new System.Drawing.Size(109, 24);
            this.txtnumeropartida.TabIndex = 54;
            this.txtnumeropartida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeropartida_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(23, 246);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(142, 19);
            this.label23.TabIndex = 54;
            this.label23.Text = "Nùmero de partida";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtsabeleer);
            this.panel2.Controls.Add(this.txtgradodeestudio);
            this.panel2.Controls.Add(this.txtnombreen);
            this.panel2.Controls.Add(this.txtparentesco);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(500, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 219);
            this.panel2.TabIndex = 57;
            // 
            // txtsabeleer
            // 
            this.txtsabeleer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsabeleer.FormattingEnabled = true;
            this.txtsabeleer.Items.AddRange(new object[] {
            "SI",
            "No"});
            this.txtsabeleer.Location = new System.Drawing.Point(204, 148);
            this.txtsabeleer.Name = "txtsabeleer";
            this.txtsabeleer.Size = new System.Drawing.Size(109, 20);
            this.txtsabeleer.TabIndex = 55;
            this.txtsabeleer.Text = "Selecciona";
            // 
            // txtgradodeestudio
            // 
            this.txtgradodeestudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgradodeestudio.FormattingEnabled = true;
            this.txtgradodeestudio.Items.AddRange(new object[] {
            "Basica",
            "Bachiller",
            "Universidad"});
            this.txtgradodeestudio.Location = new System.Drawing.Point(204, 75);
            this.txtgradodeestudio.Name = "txtgradodeestudio";
            this.txtgradodeestudio.Size = new System.Drawing.Size(109, 20);
            this.txtgradodeestudio.TabIndex = 51;
            this.txtgradodeestudio.Text = "Selecciona";
            // 
            // txtnombreen
            // 
            this.txtnombreen.Location = new System.Drawing.Point(204, 29);
            this.txtnombreen.Name = "txtnombreen";
            this.txtnombreen.Size = new System.Drawing.Size(109, 24);
            this.txtnombreen.TabIndex = 11;
            // 
            // txtparentesco
            // 
            this.txtparentesco.Location = new System.Drawing.Point(205, 107);
            this.txtparentesco.Name = "txtparentesco";
            this.txtparentesco.Size = new System.Drawing.Size(109, 24);
            this.txtparentesco.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Sabe leer y escribir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Parentesco";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Grado De Estudio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 19);
            this.label15.TabIndex = 10;
            this.label15.Text = "Nombre Encargado";
            // 
            // Encargados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncrearbase);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Encargados";
            this.Text = "Encargados";
            this.Load += new System.EventHandler(this.Encargados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtlibro;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Button btncrearbase;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtnumeropartida;
        public System.Windows.Forms.Label label23;
        public System.Windows.Forms.ComboBox txtposeepartida;
        public System.Windows.Forms.ComboBox txtzona;
        public System.Windows.Forms.TextBox txtcomplemento;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox txtsabeleer;
        public System.Windows.Forms.ComboBox txtgradodeestudio;
        public System.Windows.Forms.TextBox txtnombreen;
        public System.Windows.Forms.TextBox txtparentesco;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txttomo;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtfolio;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtnie;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtlugar;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.ComboBox txtmunicipio;
        private System.Windows.Forms.ComboBox txtdepartamento;
    }
}