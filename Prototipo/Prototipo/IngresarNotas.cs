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
    public partial class IngresarNotas : Form
    {
        private string sCn;
        private SqlConnection conn;
        private SqlCommand Insert2;
        private SqlCommand INSERT1;
        public IngresarNotas()
        {
            InitializeComponent();
            conexion.conec();
            conexion cn = new conexion();
            sCn = conexion.cadena;
            conn = new SqlConnection(sCn);

            conn.Open();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncrearbase_Click(object sender, EventArgs e)
        {
            




        }

        private void button1_Click(object sender, EventArgs e)
        {


        
            


            try
            {

                float t1nota1, t1nota2, t1nota3, t1prom;
                t1nota1 = float.Parse(this.txtactividad.Text);
                t1nota1 = t1nota1 = (float)(Math.Round((double)t1nota1, 2));
                t1nota2 = float.Parse(this.txtnotacuaderno.Text);
                t1nota2 = (float)(Math.Round((double)t1nota2, 2));
                t1nota3 = float.Parse(this.txtexamentrimestral.Text);
                t1nota3 = (float)(Math.Round((double)t1nota3, 2));

                t1prom = ((t1nota1 + t1nota2 + t1nota3) / (3));
                t1prom = (float)(Math.Round((double)t1prom, 2));




                string Insertnotas,Insertnotas1;


                Insertnotas1 = "INSERT INTO Materias(NombreMateria)";
                Insertnotas1 += "VALUES (@NombreMateria)";
                INSERT1 = new SqlCommand(Insertnotas1, conn);

                INSERT1.Parameters.Add(new SqlParameter("@NombreMateria", SqlDbType.VarChar));
                INSERT1.Parameters["@NombreMateria"].Value = txtmaterias.Text;
                INSERT1.ExecuteNonQuery();
                Insertnotas = "INSERT INTO Notas(NIE,Nombre,GradoDeEstudio,IdMateria,Periodo,NombreMateria,Actividad,NotaCuaderno,ExamenTrimestral,NotaFinal)";
                Insertnotas += "VALUES(@NIE,@Nombre,@GradoDeEstudio,@IdMateria,@Periodo,@NombreMateria,@Actividad,@NotaCuaderno,@ExamenTrimestral,@NotaFinal)";



             

                Insert2 = new SqlCommand(Insertnotas, conn);

        
                Insert2.Parameters.Add(new SqlParameter("@NIE", SqlDbType.Int));
                Insert2.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                Insert2.Parameters.Add(new SqlParameter("@GradoDeEstudio", SqlDbType.VarChar));
                Insert2.Parameters.Add(new SqlParameter("@IdMateria", SqlDbType.Int));
                Insert2.Parameters.Add(new SqlParameter("@Periodo", SqlDbType.Int));
                Insert2.Parameters.Add(new SqlParameter("@NombreMateria", SqlDbType.VarChar));
                Insert2.Parameters.Add(new SqlParameter("@Actividad", SqlDbType.Float));
                Insert2.Parameters.Add(new SqlParameter("@NotaCuaderno", SqlDbType.Float));
                Insert2.Parameters.Add(new SqlParameter("@ExamenTrimestral", SqlDbType.Float));
                Insert2.Parameters.Add(new SqlParameter("@NotaFinal", SqlDbType.Float));




            




                Insert2.Parameters["@NIE"].Value =int.Parse(txtnie.Text) ;
                Insert2.Parameters["@Nombre"].Value = txtnombre.Text;
                Insert2.Parameters["@GradoDeEstudio"].Value = txtgradodestudio.Text;

                Insert2.Parameters["@IdMateria"].Value = int.Parse(txtidmateria.Text);
                Insert2.Parameters["@Periodo"].Value =int.Parse(txttrimestre.Text);
                Insert2.Parameters["@NombreMateria"].Value = txtmaterias.Text;
                Insert2.Parameters["@Actividad"].Value = t1nota1;
        Insert2.Parameters["@NotaCuaderno"].Value = t1nota2;
        Insert2.Parameters["@ExamenTrimestral"].Value = t1nota3;
        Insert2.Parameters["@NotaFinal"].Value = t1prom;



        Insert2.ExecuteNonQuery();


                txtnombre.Text = "";
                txtgradodestudio.Text = "";
                txtactividad.Text = "";
                txtnotacuaderno.Text = "";
                txtexamentrimestral.Text = "";
           
               
                txtpromedio1.Text = "";


                txttrimestre.Text = "";
                txtidmateria.Text = "";
                txtmaterias.Text = "";



                MessageBox.Show("Registro agregado...");
                conn.Close();
            }
            catch(Exception x)
            {
                MessageBox.Show("" + x);

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        

        }

      



        private void IngresarNotas_Load(object sender, EventArgs e)
        {

         


            conexion.instanInstaladas();
           
            try
            {
               
                SqlCommand comando = new SqlCommand("SELECT PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,GradoDeEstudio,NIE from Registros ", conn);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvnotas.DataSource = tabla;
            }
            catch(Exception ex)
            {
                MessageBox.Show(" " + ex);
                conn.Close();
            }
           
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
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

        private void txt1nota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtactividad.Text.Length; i++)
            {
                if (txtactividad.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }
           
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txt1nota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1nota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtnotacuaderno.Text.Length; i++)
            {
                if (txtnotacuaderno.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txt1nota3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtexamentrimestral.Text.Length; i++)
            {
                if (txtexamentrimestral.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }
        //
        private void txt2nota1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txt2nota2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2nota2_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txt2nota3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt3nota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3nota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt3nota2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txt3nota3_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        public static string PrimerNombre;
        public static string GradoDeEstudio;
        public static string NIE;
        private void dgvnotas_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dgvnotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PrimerNombre = dgvnotas.Rows[e.RowIndex].Cells["PrimerNombre"].Value.ToString();
            GradoDeEstudio = dgvnotas.Rows[e.RowIndex].Cells["GradoDeEstudio"].Value.ToString();
            NIE = dgvnotas.Rows[e.RowIndex].Cells["NIE"].Value.ToString();
            txtnombre.Text = PrimerNombre;
            txtgradodestudio.Text = GradoDeEstudio;
            txtnie.Text = NIE;
        }

        private void txt1nota1_Leave(object sender, EventArgs e)
        {
            double nota1;
            nota1 =double.Parse( txtactividad.Text);
            if(nota1>10 || nota1 < 0)
            {
                MessageBox.Show("Nota fuera de rango, por favor vuelva a intentarlo");
                txtactividad.Text = "";
                txtactividad.Focus();
            }
        }

        private void txt1nota2_Leave(object sender, EventArgs e)
        {
            double nota;
            nota = double.Parse(txtnotacuaderno.Text);
            if (nota > 10 || nota < 0)
            {
                MessageBox.Show("Nota fuera de rango,por favor vuelva a intentarlo");
                txtnotacuaderno.Text = "";
                txtnotacuaderno.Focus();
            }
        }

        private void txt1nota3_Leave(object sender, EventArgs e)
        {
            double nota;
            nota = double.Parse(txtexamentrimestral.Text);
            if (nota > 10 || nota < 0)
            {
                MessageBox.Show("Nota fuera de rango,por favor vuelva a intentarlo");
                txtexamentrimestral.Text = "";
                txtexamentrimestral.Focus();
            }
        }

        private void txt2nota1_Leave(object sender, EventArgs e)
        {
          
        }

        private void txt2nota2_Leave(object sender, EventArgs e)
        {
        
        }

        private void txt2nota3_Leave(object sender, EventArgs e)
        {
          
        }

        private void txt3nota1_Leave(object sender, EventArgs e)
        {
        
        }

        private void txt3nota2_Leave(object sender, EventArgs e)
        {
        
        }

        private void txt3nota3_Leave(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            try
            {
                float t1nota1, t1nota2, t1nota3, t1prom;
                t1nota1 = float.Parse(this.txtactividad.Text);
                t1nota2 = float.Parse(this.txtnotacuaderno.Text);
                t1nota3 = float.Parse(this.txtexamentrimestral.Text);

                t1prom = ((t1nota1 + t1nota2 + t1nota3) / (3));
                t1prom = (float)(Math.Round((double)t1prom, 2));
                this.txtpromedio1.Text = (t1prom).ToString();
            }
            catch (Exception c)
            {
                MessageBox.Show("" + c);
            }
        }

        private void dgvnotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtmaterias_Leave(object sender, EventArgs e)
        {
            if (txtmaterias.Text == "Ciencias")
            {
                txtidmateria.Text = "1";
            }
            if (txtmaterias.Text == "Matematica")
            {
                txtidmateria.Text = "2";
            }
            if (txtmaterias.Text == "Sociales")
            {
                txtidmateria.Text = "3";
            }
            if (txtmaterias.Text == "Ingles")
            {
                txtidmateria.Text = "4";
            }
            if (txtmaterias.Text == "Lenguaje")
            {
                txtidmateria.Text = "5";
            }
        }
    }
    }
    
   

