using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Reporte_de_Notas.Notas' Puede moverla o quitarla según sea necesario.
            /* this.NotasTableAdapter.Fill(this.Reporte_de_Notas.Notas);

              this.reportViewer1.RefreshReport();*/
        }

        public void FiltroDDatos(int x)
        {
            try
            {
                NotasTableAdapter.FBfiltrar(Reporte_de_Notas.Notas, x);
                reportViewer1.RefreshReport();
                this.Show();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void NotasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
