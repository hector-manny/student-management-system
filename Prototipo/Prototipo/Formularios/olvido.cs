using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Runtime.InteropServices;
namespace Prototipo.Formularios
{
    public partial class olvido : Form


    {
        private SqlConnection conn;
        private string sCn;
       
        public olvido()
        {
            InitializeComponent();
            conexion cn = new conexion();

            conexion.conec();

            sCn = conexion.cadena;

            conn = new SqlConnection(sCn);
        }

        private void olvido_Load(object sender, EventArgs e)
        {
            conexion.instanInstaladas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string re = "SELECT  Contraseña  FROM Usuarios WHERE Usuario='" + txtusuario.Text + "' ";
                SqlCommand comando = new SqlCommand(re, conn);
                
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    MessageBox.Show("La contraseña es: " + leer["Contraseña"].ToString());
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("El usuario no existe!");
                    conn.Close();
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("" + x);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login re = new login();
            

            re.Show();
            this.Close();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
