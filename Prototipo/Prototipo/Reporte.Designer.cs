namespace Prototipo
{
    partial class Reporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reporte));
            this.NotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Reporte_de_Notas = new Prototipo.Reporte_de_Notas();
            this.NotasTableAdapter = new Prototipo.Reporte_de_NotasTableAdapters.NotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NotasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_de_Notas)).BeginInit();
            this.SuspendLayout();
            // 
            // NotasBindingSource
            // 
            this.NotasBindingSource.DataMember = "Notas";
            this.NotasBindingSource.DataSource = this.Reporte_de_Notas;
            this.NotasBindingSource.CurrentChanged += new System.EventHandler(this.NotasBindingSource_CurrentChanged);
            // 
            // Reporte_de_Notas
            // 
            this.Reporte_de_Notas.DataSetName = "Reporte_de_Notas";
            this.Reporte_de_Notas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NotasTableAdapter
            // 
            this.NotasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 424);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reporte";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_de_Notas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NotasBindingSource;
        private Reporte_de_Notas Reporte_de_Notas;
        private Reporte_de_NotasTableAdapters.NotasTableAdapter NotasTableAdapter;
    }
}