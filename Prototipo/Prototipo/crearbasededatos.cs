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
    public partial class crearbasededatos : Form
    {
        private SqlConnection conn;
        private SqlCommand Insert1;
        private SqlCommand Insert2;
        private SqlCommand Insert3;
        private SqlCommand Insert4;
        private SqlCommand Insert5;
        private string sCn;
    
        public crearbasededatos()
        {
            InitializeComponent();
            conexion cn = new conexion();
           
            conexion.conec();
            
            sCn = conexion.cadena;
           
            conn = new SqlConnection(sCn);
          
            conn.Open();

        }
      

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
        }

        private void btncrearbase_Click(object sender, EventArgs e)
        {

            
            //// asociando los textbox a la base

            try
            {

                string InsertRegistro,InsertDiscapacidad,InsertEconomia,InsertMedicas,InserFamiliar;
                InsertRegistro = "INSERT INTO Registros(NIE,Turno,PrimerNombre,SegundoNombre,PrimerApellido,SegundoApellido,Edad,Telefono,GradoDeEstudio,RepiteGrado,Sexo,EstudioParvularia)";
                InsertRegistro += "VALUES(@NIE,@Turno,@PrimerNombre,@SegundoNombre,@PrimerApellido,@SegundoApellido,@Edad,@Telefono,@GradoDeEstudio,@RepiteGrado,@Sexo,@EstudioParvularia)";

                Insert1 = new SqlCommand(InsertRegistro, conn);

                Insert1.Parameters.Add(new SqlParameter("@NIE", SqlDbType.Int));
                Insert1.Parameters.Add(new SqlParameter("@Turno", SqlDbType.VarChar));
                Insert1.Parameters.Add(new SqlParameter("@PrimerNombre", SqlDbType.VarChar));
                Insert1.Parameters.Add(new SqlParameter("@SegundoNombre", SqlDbType.VarChar));
                Insert1.Parameters.Add(new SqlParameter("@PrimerApellido", SqlDbType.VarChar));
                Insert1.Parameters.Add(new SqlParameter("@SegundoApellido", SqlDbType.VarChar));
                Insert1.Parameters.Add(new SqlParameter("@Edad", SqlDbType.Int));
                Insert1.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.NChar));
                Insert1.Parameters.Add(new SqlParameter("@GradoDeEstudio", SqlDbType.VarChar));
                Insert1.Parameters.Add(new SqlParameter("@RepiteGrado", SqlDbType.NChar));
                Insert1.Parameters.Add(new SqlParameter("@Sexo", SqlDbType.NChar));
                Insert1.Parameters.Add(new SqlParameter("@EstudioParvularia", SqlDbType.VarChar));



                int Nie = int.Parse(txtNie.Text);
                int edad = int.Parse(txtedad.Text);
                int telefono = int.Parse(txttelefono.Text);




                Insert1.Parameters["@NIE"].Value = Nie;
                Insert1.Parameters["@Turno"].Value = txtturno.Text;
                Insert1.Parameters["@PrimerNombre"].Value = txtprimernombre.Text;
                Insert1.Parameters["@SegundoNombre"].Value = txtsegundonombre.Text;
                Insert1.Parameters["@PrimerApellido"].Value = txtprimerapellido.Text;
                Insert1.Parameters["@SegundoApellido"].Value = txtsegundoapellido.Text;
                Insert1.Parameters["@Edad"].Value = edad;
                Insert1.Parameters["@Telefono"].Value = txttelefono.Text;
                Insert1.Parameters["@GradoDeEstudio"].Value = txtgradodestudio.Text;
                Insert1.Parameters["@RepiteGrado"].Value = txtrepitegrado.Text;
                Insert1.Parameters["@Sexo"].Value = txtsexo.Text;
                Insert1.Parameters["@EstudioParvularia"].Value = txtestudioparvularia.Text;

                Insert1.ExecuteNonQuery();
                //Discapacidad
                InsertDiscapacidad = "INSERT INTO Discapacidades(TipoDicapacidad,RecibeEducacionEspecial)";
                InsertDiscapacidad += "VALUES(@TipoDicapacidad,@RecibeEducacionEspecial)";
                Insert2 = new SqlCommand(InsertDiscapacidad, conn);
                Insert2.Parameters.Add(new SqlParameter("@TipoDicapacidad", SqlDbType.VarChar));
                Insert2.Parameters.Add(new SqlParameter("@RecibeEducacionEspecial", SqlDbType.NChar));
                Insert2.Parameters["@TipoDicapacidad"].Value = txttipodisca.Text;
                Insert2.Parameters["@RecibeEducacionEspecial"].Value = txteducaciones.Text;
                Insert2.ExecuteNonQuery();

                //Economica
                InsertEconomia= "INSERT INTO ActividadesEconomicas(TipoActividad)";
               InsertEconomia += "VALUES(@TipoActividad)";
                Insert3 = new SqlCommand(InsertEconomia, conn);
                Insert3.Parameters.Add(new SqlParameter("@TipoActividad", SqlDbType.VarChar));
                Insert3.Parameters["@TipoActividad"].Value = txtactividadeconomica.Text;

                Insert3.ExecuteNonQuery();
                
                //condicionfamiliar
                InserFamiliar = "INSERT INTO CondicionesFamiliares(TipoCondicionFamiliar)";
                InserFamiliar += "VALUES(@TipoCondicionFamiliar)";
                Insert4 = new SqlCommand(InserFamiliar, conn);
                Insert4.Parameters.Add(new SqlParameter("@TipoCondicionFamiliar", SqlDbType.VarChar));

                Insert4.Parameters["@TipoCondicionFamiliar"].Value = txtcondicionfamiliar.Text;
                Insert4.ExecuteNonQuery();

                //condiciones medicas

                InsertMedicas = "INSERT INTO CondicionesMedicas(VacunasCompletas,ProblemaSalud,TipoProblemaSalud)";
                InsertMedicas += "VALUES(@VacunasCompletas,@ProblemaSalud,@TipoProblemaSalud)";
                Insert5 = new SqlCommand(InsertMedicas, conn);
                Insert5.Parameters.Add(new SqlParameter("@VacunasCompletas", SqlDbType.NChar));
                Insert5.Parameters.Add(new SqlParameter("@ProblemaSalud", SqlDbType.NChar));
                Insert5.Parameters.Add(new SqlParameter("@TipoProblemaSalud", SqlDbType.VarChar));
                Insert5.Parameters["@VacunasCompletas"].Value = txtvacunascompletas.Text;
                Insert5.Parameters["@ProblemaSalud"].Value = txtproblemasdesalud.Text;
                Insert5.Parameters["@TipoProblemaSalud"].Value = txtproblemas.Text;
                Insert5.ExecuteNonQuery();

                Program.nie = txtNie.Text;
                txtNie.Text = "";
                txtturno.Text = "";
                txtprimernombre.Text = "";
                txtsegundonombre.Text = "";
                txtprimerapellido.Text = "";
                txtsegundoapellido.Text = "";
                txtedad.Text = "";
                txttelefono.Text = "";
                txtgradodestudio.Text = "";
                txtrepitegrado.Text = "";
                txtsexo.Text = "";
                txtestudioparvularia.Text = "";
              
                txtsexo.Text = "";
                txttipodisca.Text = "";
                txtcondicionfamiliar.Text = "";
                txteducaciones.Text = "";
                txtactividadeconomica.Text = "";
                txtvacunascompletas.Text = "";
                txtproblemasdesalud.Text = "";
                txtproblemas.Text = "";


                



                MessageBox.Show("Registro agregado...");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("El Registro no fue agregado");
                MessageBox.Show(" " + ex);
            }

           
        }
        
    
        private void crearbasededatos_Load(object sender, EventArgs e)
        {
            conexion.instanInstaladas();
           

        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            
         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtturno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txttelefono_Leave(object sender, EventArgs e)
        {
            if (txttelefono.Text.Trim().Length != 8)
            {
                MessageBox.Show("El Teléfono debe tener 8 dígitos");
                return;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtsegundoapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo no permite espacios ni numeros", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtprimerapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo no permite espacios ni numeros", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtsegundonombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo no permite espacios ni numeros", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void txtsegundonombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNie_Leave(object sender, EventArgs e)
        {
            if (txtNie.Text.Trim().Length != 7)
            {
                MessageBox.Show("El NIE debe contener 7 digitos");
                return;
            }

        }

        private void txtprimernombre_Leave(object sender, EventArgs e)
        {
        
        }

        private void txtprimernombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Este campo no permite espacios ni numeros", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // La conexión a usar, indicando la base master 
            SqlConnection cnn = new SqlConnection("Server=" + conexion.miservidor + "; " + "database=master; integrated security=yes");
            // La orden T-SQL para crear la Base de Datos 
            string s = "CREATE DATABASE " + "ComplejoEducativoM";

            string s1 = "USE ComplejoEducativoM" +
                  "CREATE TABLE Registros(" +
                  "IdRegistro int PRIMARY KEY IDENTITY(1,1)," +
                  "NIE int NOT NULL," +
                  "Turno Varchar(30) NOT NULL, " +
                  "PrimerNombre Varchar(50) NOT NULL," +
                  "SegundoNombre Varchar(50) NOT NULL," +
                  "PrimerApellido Varchar(50) NOT NULL," +
                  "SegundoApellido varchar(50) NOT NULL," +
                  "Edad int NOT NULL," +
                  "Telefono nchar(9) NOT NULL," +
                  "GradoDeEstudio varchar(30) NOT NULL," +
                  "RepiteGrado Nchar(2) NOT NULL," +
                  "Sexo Nchar(10) NOT NULL," +
                  "EstudioParvularia Nchar(2) NOT NULL," +
                  "IdPartida int," +
                  "IdDireccion int," +
                  "IdDiscapacidad int," +
                  "IdEncargado int," +
                  "IdActividadEconomica int," +
                  "IdCondicionFamiliar int," +
                  "IdCondicionFamiliar int)";


            SqlCommand cmd = new SqlCommand(s, cnn);
            SqlCommand cmd1 = new SqlCommand(s1, cnn);


            try
            {

                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();

                cnn.Close();
                MessageBox.Show("Base Creada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error al crear la base",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
       

        private void btnencargados_Click(object sender, EventArgs e)
        {
          
        }

        private void txtNie_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtproblemasdesalud_Leave(object sender, EventArgs e)
        {
            if (txtproblemasdesalud.Text == "Si")
            {
                txtproblemas.Enabled = true;

            }
            else
            {
                txtproblemas.Enabled = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
