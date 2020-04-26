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
    public partial class login : Form
    {
        
        private SqlConnection conn;
        private string sCn;
      
        public login()
        {
            InitializeComponent();
            conexion cn = new conexion();

            conexion.conec();

            sCn = conexion.cadena;

            conn = new SqlConnection(sCn);


           
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void logear(string usuario, string contrasena)
        {
            try
            {

                conn.Open();


                SqlCommand cmd = new SqlCommand("SELECT Nombre, TipoUsuario FROM usuarios WHERE Usuario = @usuariox AND Contraseña = @pasx", conn);
                cmd.Parameters.AddWithValue("usuariox", usuario);
                cmd.Parameters.AddWithValue("pasx", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {

                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "admin")
                    {
                        Program.cargo = (dt.Rows[0][1].ToString());
                        new principal(dt.Rows[0][0].ToString()).Show();
                     
                    }
                    else if (dt.Rows[0][1].ToString() == "usuario")
                    {
                        Program.cargo = dt.Rows[0][1].ToString();
                        new principal(dt.Rows[0][0].ToString()).Show();
                     

                    }
                    else if (dt.Rows[0][1].ToString() == "profesor")
                    {
                        Program.cargo = dt.Rows[0][1].ToString();
                        new principal(dt.Rows[0][0].ToString()).Show();

                       
                    }
                    else if (dt.Rows[0][1].ToString() == "director")
                    {
                        Program.cargo = dt.Rows[0][1].ToString();
                        new principal(dt.Rows[0][0].ToString()).Show();
                       

                    }

                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }

                login s = new login();
                s.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        private void login_Load(object sender, EventArgs e)
        {
            conexion.instanInstaladas();

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            logear(this.txtusuario.Text, this.txtcontra.Text);
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection("Server=" + conexion.miservidor + "; " + "database=master; integrated security=yes");


            string s = "CREATE DATABASE " + "ComplejoEducativo";

            string s0 = "USE ComplejoEducativo;" +
                  "CREATE TABLE Usuarios(" +
                  "Nombre Varchar(20)," +
                  "Usuario Varchar(20)," +
                  "Contraseña varchar(25)," +
                  "TipoUsuario Varchar(25)," +




                "UNIQUE(Usuario));";

            string s1 = "USE ComplejoEducativo;" +
                 "CREATE TABLE Partidas(" +
                 "IdPartida int PRIMARY KEY IDENTITY(1,1)," +
                 "PoseePartida nchar(2)NOT NULL," +
                 "NumeroPartida int," +
                 "Folio int," +
                 "Tomo int," +
                 "Libro int," +
                 "LugarNacimiento varchar(30)," +
                 "FechaNacimiento date," +
                 "NIE int," +

                 "CHECK(PoseePartida IN ('SI','NO','Si','No','si','no'))," +

                 "CHECK(NumeroPartida>=0)," +

                 "CHECK(Folio>=0)," +

                 "CHECK(Tomo>=0)," +

                 "CHECK(Libro>=0));";

            string s3 = "USE ComplejoEducativo;" +
                                "CREATE TABLE Direcciones(" +
              "IdDireccion int PRIMARY KEY IDENTITY(1,1)," +
              "Departamento varchar(30) NOT NULL," +
              "Municipio varchar(30) NOT NULL," +
              "Zona varchar(8)," +
              "Complemento varchar(35) NOT NULL," +
              "Libro int," +

              "CHECK(Zona IN ('Rural','Urbana','RURAL','URBANA','rural','urbana')));";


            string s4 = "USE ComplejoEducativo;" +
        "CREATE TABLE Discapacidades(" +
        "IdDiscapacidad int PRIMARY KEY IDENTITY(1,1)," +
        "TipoDicapacidad varchar (35)," +
        "RecibeEducacionEspecial nchar(2)," +

        "CHECK(RecibeEducacionEspecial IN ('SI','NO','Si','No','si','no')));";

            string s5 = "USE ComplejoEducativo;" +
              "CREATE TABLE Encargados(" +
              "IdEncargado int PRIMARY KEY IDENTITY(1,1)," +
              "Nombre varchar (20)," +
              "GradoDeEstudioQuePosee varchar(30)," +
              "Parentesco varchar(30)," +
              "SabeLeeryEscribir nchar(2)," +

              "CHECK(SabeLeeryEscribir IN ('SI','NO','Si','No','si','no')));";

            string s6 = "USE ComplejoEducativo;" +
              "CREATE TABLE ActividadesEconomicas(" +
              "IdActividadEconomica int PRIMARY KEY IDENTITY(1,1)," +
              "TipoActividad varchar(60));";

            string s7 = "USE ComplejoEducativo;" +
             "CREATE TABLE CondicionesFamiliares(" +
             "IdCondicionFamiliar int PRIMARY KEY IDENTITY(1,1)," +
             "TipoCondicionFamiliar varchar(60));";

            string s8 = "USE ComplejoEducativo;" +
             "CREATE TABLE CondicionesMedicas(" +
             "IdCondicionMedica int PRIMARY KEY IDENTITY(1,1)," +
             "VacunasCompletas nchar(2)," +
             "ProblemaSalud nchar(2)," +
             "TipoProblemaSalud varchar(30)," +

             "CHECK(VacunasCompletas IN ('SI','NO','Si','No','si','no'))," +

             "CHECK(ProblemaSalud IN ('SI','NO','Si','No','si','no')));";

            string s9 = "USE ComplejoEducativo;" +
             "CREATE TABLE Registros(" +
                  "NIE int PRIMARY KEY NOT NULL," +
                  "Turno Varchar(30) NOT NULL," +
                  "PrimerNombre Varchar(50) NOT NULL," +
                  "SegundoNombre Varchar(50) ," +
                  "PrimerApellido Varchar(50) NOT NULL," +
                  "SegundoApellido varchar(50)," +
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
                  "IdCondicionMedica int," +



            "UNIQUE(NIE)," +

                 "CHECK(Edad>0)," +

                 "CHECK(NIE>0)," +






                 "CHECK (Sexo IN ('MASCULINO','FEMENINO','Masculino','Femenino','masculino','femenino'))," +

                 "CHECK(EstudioParvularia IN ('SI','NO','Si','No','si','no'))," +
                  "FOREIGN KEY(IdPartida)" +
                 "REFERENCES Partidas(IdPartida),"

                 + "FOREIGN KEY(IdDireccion)" +
                 "REFERENCES Direcciones(IdDireccion),"

                 + "FOREIGN KEY(IdDiscapacidad)" +
                 "REFERENCES Discapacidades(IdDiscapacidad),"

                 + "FOREIGN KEY(IdEncargado)"
                 + "REFERENCES Encargados(IdEncargado),"

                 + "FOREIGN KEY(IdActividadEconomica)"
                 + "REFERENCES ActividadesEconomicas(IdActividadEconomica),"

                 + "FOREIGN KEY(IdCondicionFamiliar)"
                 + "REFERENCES CondicionesFamiliares(IdCondicionFamiliar),"

                 + "FOREIGN KEY(IdCondicionMedica)"
                 + "REFERENCES CondicionesMedicas(IdCondicionMedica))";


            string a1 = "USE ComplejoEducativo;" +
              "CREATE TABLE Notas(" +
                  "IdNota int IDENTITY(1,1)," +
                  "NIE int," +
                  "Nombre VARCHAR(30)," +
                  "GradoDeEstudio VARCHAR(30)," +
                  "IdMateria int ," +
                  "Periodo int," +
                  "Actividad float," +
                  "NotaCuaderno float," +
                  "ExamenTrimestral float," +
                  "NotaFinal float," +
                  "PRIMARY KEY(NIE,IdMateria,Periodo,IdNota),"
                  +
                "NombreMateria Varchar(30)," 



                 + "CHECK(IdMateria>0)," +


            "CHECK(Actividad>=0)," +


            "CHECK(NotaCuaderno>=0)," +

            "CHECK(ExamenTrimestral>=0)," +


                  "CHECK(NotaFinal>=0)," +


                  "CHECK(Periodo>0),"
                  + "FOREIGN KEY(NIE)"
                  + "REFERENCES Registros(NIE))";


            string a2 = "USE ComplejoEducativo;" +
                "CREATE TABLE Materias(" +
                "IdMateria int IDENTITY (1,1) PRIMARY KEY," +
                "NombreMateria Varchar(30));";

            string a3 = "USE ComplejoEducativo;" +
                "CREATE TABLE Docentes(" +
                "IdDocente int PRIMARY KEY IDENTITY(1,1)," +
                "IdMateria int," +
                "PrimerNombre Varchar(25) NOT NULL," +
                "SegundoNombre Varchar(25) NOT NULL," +
                "PrimerApellido Varchar(25) NOT NULL," +
                "SegundoApellido varchar(25) NOT NULL," +
                "Edad int NOT NULL," +
                "Telefono nchar(9) NOT NULL," +
                "NIP int," +
                "AsignaturaQueImparte varchar(15) NOT NULL," +
                "IdNotas int," +

                "CHECK(Edad>0)," +

                "UNIQUE(NIP),"
                + "FOREIGN KEY(IdMateria)"
                + "REFERENCES Materias(IdMateria))";

            string a4 = "USE ComplejoEducativo;" +
             "CREATE TABLE Salones(" +
             "IdSalon int PRIMARY KEY IDENTITY(1,1)," +
             "Grado varchar(10) NOT NULL," +
             "Seccion varchar(10) NOT NULL," +
             "Capacidad int NOT NULL," +
             "IdDocente int," +


             "CHECK(Capacidad>0 AND Capacidad<=45),"
             + "FOREIGN KEY(IdDocente)"
             + "REFERENCES Docentes(IdDocente))";





            SqlCommand cmd = new SqlCommand(s, cnn);
            SqlCommand cmd0 = new SqlCommand(s0, cnn);

            SqlCommand cmd1 = new SqlCommand(s1, cnn);

            SqlCommand cmd3 = new SqlCommand(s3, cnn);
            SqlCommand cm4 = new SqlCommand(s4, cnn);
            SqlCommand cmd5 = new SqlCommand(s5, cnn);
            SqlCommand cmd6 = new SqlCommand(s6, cnn);
            SqlCommand cmd7 = new SqlCommand(s7, cnn);
            SqlCommand cmd8 = new SqlCommand(s8, cnn);
            SqlCommand cm1 = new SqlCommand(s9, cnn);
            SqlCommand cm3 = new SqlCommand(a1, cnn);
            SqlCommand cm5 = new SqlCommand(a2, cnn);
            SqlCommand cm6 = new SqlCommand(a3, cnn);
            SqlCommand cm7 = new SqlCommand(a4, cnn);
            try
            {

                cnn.Open();
                cmd.ExecuteNonQuery();
                cmd0.ExecuteNonQuery();

                cmd1.ExecuteNonQuery();


                cmd3.ExecuteNonQuery();
                cm4.ExecuteNonQuery();
                cmd5.ExecuteNonQuery();
                cmd6.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmd8.ExecuteNonQuery();
                cm1.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm5.ExecuteNonQuery();
                cm6.ExecuteNonQuery();
                cm7.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Base Creada");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "La base ya Existe",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                cnn.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logear(txtusuario.Text, txtcontra.Text);
           
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            olvido ol = new olvido();
       
            ol.Show();
            this.Close();
            this.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NuevoU re = new NuevoU();


            re.Show();
            this.Close();
            this.Dispose();
        }
    }
}
