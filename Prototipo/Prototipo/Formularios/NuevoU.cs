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

namespace Prototipo.Formularios
{
    public partial class NuevoU : Form
    {
        private SqlConnection conn;
        private string sCn;
        private SqlCommand insert1;
        public NuevoU()
        {
            InitializeComponent();
            conexion cn = new conexion();

            conexion.conec();

            sCn = conexion.cadena;

            conn = new SqlConnection(sCn);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login re = new login();


            re.Show();
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            
            {
                conn.Open();

                string inser1;
                inser1 = "INSERT INTO Usuarios(Nombre,Usuario,Contraseña,TipoUsuario)";
                inser1 += "VALUES (@Nombre,@Usuario,@Contraseña,@TipoUsuario)";
                insert1 = new SqlCommand(inser1, conn);

                insert1.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                insert1.Parameters["@Nombre"].Value = txtnombre.Text;
                insert1.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar));
                insert1.Parameters["@Usuario"].Value = txtusuario.Text;
                insert1.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar));
                insert1.Parameters["@Contraseña"].Value = txtcontra.Text;
                insert1.Parameters.Add(new SqlParameter("@TipoUsuario", SqlDbType.VarChar));
                insert1.Parameters["@TipoUsuario"].Value = txttipo.Text;


                insert1.ExecuteNonQuery();
                txtusuario.Text = "";
                txtcontra.Text = "";
                txttipo.Text = "";
                txtnombre.Text = "";
                MessageBox.Show("Los datos fueron guardados");
                conn.Close();
            }
            catch(Exception el)
            {
                MessageBox.Show("Hubo un error" +el);
                    conn.Close();
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void NuevoU_Load(object sender, EventArgs e)
        {
            conexion.instanInstaladas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
