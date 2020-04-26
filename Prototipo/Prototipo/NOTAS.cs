using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Prototipo
{
    public partial class NOTAS : Form
    {
        private string sCn;
        private SqlConnection conn;
        
        public NOTAS()
        {
            InitializeComponent();
            conexion.conec();
            conexion cn = new conexion();
            sCn = conexion.cadena;
            conn = new SqlConnection(sCn);

            conn.Open();
        }

        private void txtbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtbuscar.Text != "")
            {
                dgvnotas.CurrentCell = null;
                foreach (DataGridViewRow r in dgvnotas.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvnotas.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtbuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {

            }
        }

        private void NOTAS_Load(object sender, EventArgs e)
        {
            conexion.instanInstaladas();

            try
            {

                SqlCommand comando = new SqlCommand("SELECT Nombre,GradoDeEstudio,Periodo,GradoDeEstudio,NIE,NombreMateria,Actividad,NotaCuaderno,ExamenTrimestral,NotaFinal  from Notas ", conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvnotas.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex);
                conn.Close();
            }
        }

        private void dgvnotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre;
            String NIE;
            Nombre = dgvnotas.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtnombre.Text = Nombre;

            NIE = dgvnotas.Rows[e.RowIndex].Cells["NIE"].Value.ToString();
            txtnie.Text = NIE;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ni;
            ni = int.Parse(txtnie.Text);
            Reporte re = new Reporte();
            re.FiltroDDatos(ni);
            re.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtmateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtmateria.Text != "")
            {
                dgvnotas.CurrentCell = null;
                foreach (DataGridViewRow r in dgvnotas.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvnotas.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtmateria.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {

            }
        }
    }
}

