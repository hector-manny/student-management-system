using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Prototipo
{
    public partial class principal : Form 
    {
        private SqlConnection conn;
      
        private string sCn;
        public principal(string nombre)
        {
            InitializeComponent();
            conexion.conec();
            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pensándole como argumento la cadena
            conn = new SqlConnection(sCn);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnslide_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (menuvertical.Width == 67)
            {
                menuvertical.Width = 250;
            }
            else
            {
                menuvertical.Width = 67;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btndeslizar_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFromInpanel(new crearbasededatos());
            btninformacion.Enabled = true;
        }

        private void AbrirFromInpanel(object formhijo)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }
        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imagen1_Click(object sender, EventArgs e)
        {
            AbrirFromInpanel(new crearbasededatos());
        }

        private void principal_Load(object sender, EventArgs e)
        {
            conexion.instanInstaladas();

            privilegio();
          

        }

        private void privilegio()
        {
            if (Program.cargo=="profesor")
            {
                btncrearbase.Visible = false;
                btninformacion.Visible = false;
                picnuevo.Visible = false;
                picpersonal.Visible = false;
            }
            else
            {

            }
            if (Program.cargo=="director")
            {
                btningresar.Enabled = false;

            }
            else
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFromInpanel(new IngresarNotas());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFromInpanel(new Form1());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AbrirFromInpanel(new Encargados());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFromInpanel(new NOTAS());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void menuvertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncrearbase_Leave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cerrarseccionboton_Click(object sender, EventArgs e)
        {

            this.Close();

            Formularios.login a = new Formularios.login();
            a.Show();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
 }

