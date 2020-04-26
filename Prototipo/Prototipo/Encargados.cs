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
    public partial class Encargados : Form
    {
        private string sCn;
        private SqlConnection conn;
        private SqlCommand Insert;
        private SqlCommand Insertp;
        private SqlCommand Inserte;
        public Encargados()
        {
            InitializeComponent();
            conexion.conec();
            conexion cn = new conexion();
            sCn = conexion.cadena;
            conn = new SqlConnection(sCn);

            conn.Open();
        }

        private void txtNie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncrearbase_Click(object sender, EventArgs e)
        {
            
            string InsertDireccion,InsertPartidas,InsertEncargado;
            try
            {
                InsertDireccion = "INSERT INTO Direcciones(Departamento,Municipio,Zona,Complemento)";
                InsertDireccion += "VALUES(@Departamento,@Municipio,@Zona,@Complemento)";
                Insert = new SqlCommand(InsertDireccion, conn);
                Insert.Parameters.Add(new SqlParameter("@Departamento", SqlDbType.VarChar));
                Insert.Parameters.Add(new SqlParameter("@Municipio", SqlDbType.VarChar));
                Insert.Parameters.Add(new SqlParameter("@Zona", SqlDbType.VarChar));
                Insert.Parameters.Add(new SqlParameter("@Complemento", SqlDbType.VarChar));
                //Ingresando Datos
                Insert.Parameters["@Departamento"].Value = txtdepartamento.Text;
                Insert.Parameters["@Municipio"].Value = txtmunicipio.Text;
                Insert.Parameters["@Zona"].Value = txtzona.Text;
                Insert.Parameters["@Complemento"].Value = txtcomplemento.Text;
           
                Insert.ExecuteNonQuery();

                //partida
                InsertPartidas = "INSERT INTO Partidas(PoseePartida,NumeroPartida,Folio,Tomo,Libro,LugarNacimiento,FechaNacimiento,NIE)";
                InsertPartidas += "VALUES(@PoseePartida,@NumeroPartida,@Folio,@Tomo,@Libro,@LugarNacimiento,@FechaNacimiento,@NIE)";
                Insertp = new SqlCommand(InsertPartidas, conn);
                Insertp.Parameters.Add(new SqlParameter("@PoseePartida", SqlDbType.NChar));
                Insertp.Parameters.Add(new SqlParameter("@NumeroPartida", SqlDbType.Int));
                Insertp.Parameters.Add(new SqlParameter("@Folio", SqlDbType.Int));
                Insertp.Parameters.Add(new SqlParameter("@Tomo", SqlDbType.Int));
                Insertp.Parameters.Add(new SqlParameter("@Libro", SqlDbType.Int));
                Insertp.Parameters.Add(new SqlParameter("@LugarNacimiento", SqlDbType.VarChar));
                Insertp.Parameters.Add(new SqlParameter("@FechaNacimiento", SqlDbType.Date));
                Insertp.Parameters.Add(new SqlParameter("@NIE", SqlDbType.Int));
                //Ingresando Datos
                Insertp.Parameters["@PoseePartida"].Value = txtposeepartida.Text;
                Insertp.Parameters["@NumeroPartida"].Value = txtnumeropartida.Text;
                Insertp.Parameters["@Folio"].Value = txtfolio.Text;
                Insertp.Parameters["@Tomo"].Value = txttomo.Text;
                Insertp.Parameters["@Libro"].Value = txtlibro.Text;
                Insertp.Parameters["@LugarNacimiento"].Value = txtlugar.Text;
                Insertp.Parameters["@FechaNacimiento"].Value = txtfecha.Text;
                Insertp.Parameters["@NIE"].Value = txtnie.Text;

                Insertp.ExecuteNonQuery();
                //Encargados
                InsertEncargado = "INSERT INTO Encargados(Nombre,GradoDeEstudioQuePosee,Parentesco,SabeLeeryEscribir)";
                InsertEncargado += "VALUES(@Nombre,@GradoDeEstudioQuePosee,@Parentesco,@SabeLeeryEscribir)";
                Inserte = new SqlCommand(InsertEncargado, conn);
                Inserte.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
                Inserte.Parameters.Add(new SqlParameter("@GradoDeEstudioQuePosee", SqlDbType.VarChar));
                Inserte.Parameters.Add(new SqlParameter("@Parentesco", SqlDbType.VarChar));
                Inserte.Parameters.Add(new SqlParameter("@SabeLeeryEscribir", SqlDbType.NChar));
                //Ingresando Datos
                Inserte.Parameters["@Nombre"].Value = txtnombreen.Text;
                Inserte.Parameters["@GradoDeEstudioQuePosee"].Value = txtgradodeestudio.Text;
                Inserte.Parameters["@Parentesco"].Value = txtparentesco.Text;
                Inserte.Parameters["@SabeLeeryEscribir"].Value = txtsabeleer.Text;

                Inserte.ExecuteNonQuery();
                MessageBox.Show("El registro fue guardado con exito");

                txtdepartamento.Text = "";
                txtmunicipio.Text = "";
                txtzona.Text = "";
                txtcomplemento.Text = "";
                txtposeepartida.Text = "";
                txtnumeropartida.Text = "";
                txtfolio.Text = "";
                txttomo.Text = "";
                txtlibro.Text = "";
                txtlugar.Text = "";
                txtfecha.Text = "";
                txtnie.Text = "";
                txtnombreen.Text = "";
                txtgradodeestudio.Text = "";
                txtparentesco.Text = "";
                txtsabeleer.Text = "";


          
            }
            catch(Exception i)
            {
                MessageBox.Show("" + i);
            }

        }

        private void Encargados_Load(object sender, EventArgs e)
        {
            conexion.instanInstaladas();


            txtnie.Text = Program.nie;
            
        }

        private void txtnumeropartida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtfolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txttomo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtlibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtnie_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txtnie_Leave(object sender, EventArgs e)
        {
            if (txtnie.Text.Trim().Length != 7)
            {
                MessageBox.Show("El NIE debe contener 7 digitos");
                return;
            }
        }

        private void txtnie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtdepartamento_Leave(object sender, EventArgs e)
        {
            if(txtdepartamento.Text== "Ahuachapán")
            {
                txtmunicipio.Items.Add("Ahuachapán");
                txtmunicipio.Items.Add("Apaneca");
                txtmunicipio.Items.Add("Atiquizaya");
                txtmunicipio.Items.Add("Concepción de Ataco");
                txtmunicipio.Items.Add("El Refugio");
                txtmunicipio.Items.Add("Guaymango");
                txtmunicipio.Items.Add("Jujutla");
                txtmunicipio.Items.Add("San Francisco Menéndez");
                txtmunicipio.Items.Add("San Pedro Puxtla");
                txtmunicipio.Items.Add("Tacuba");
                txtmunicipio.Items.Add("El Refugio");
                txtmunicipio.Items.Add("Turín");
            }
            if (txtdepartamento.Text == "Santa Ana")
            {
                txtmunicipio.Items.Add("Candelaria de la Frontera");
                txtmunicipio.Items.Add("ApanecaChalchuapaAtiquizaya");
                txtmunicipio.Items.Add("Coatepeque");
                txtmunicipio.Items.Add("El Congo");
                txtmunicipio.Items.Add("El Porvenir");
                txtmunicipio.Items.Add("Masahuat");
                txtmunicipio.Items.Add("Metapán");
                txtmunicipio.Items.Add("San Antonio Pajonal");
                txtmunicipio.Items.Add("San Sebastián Salitrillo");
                txtmunicipio.Items.Add("Santa Ana");
                txtmunicipio.Items.Add("Santa Rosa Guachipilín");
                txtmunicipio.Items.Add("Santiago de la Frontera");
                txtmunicipio.Items.Add("Texistepeque");
            }

            if (txtdepartamento.Text == "Sonsonate")
            {
                txtmunicipio.Items.Add("Acajutla");
                txtmunicipio.Items.Add("Armenia");
                txtmunicipio.Items.Add("Caluco");
                txtmunicipio.Items.Add("Cuisnahuat");
                txtmunicipio.Items.Add("Izalco");
                txtmunicipio.Items.Add("Juayúa");
                txtmunicipio.Items.Add("Nahuizalco");
                txtmunicipio.Items.Add("Nahulingo");
                txtmunicipio.Items.Add("Salcoatitán");
                txtmunicipio.Items.Add("San Antonio del Monte");
                txtmunicipio.Items.Add("San Julián");
                txtmunicipio.Items.Add("Santa Catarina Masahuat");
                txtmunicipio.Items.Add("Santa Isabel Ishuatán");
                txtmunicipio.Items.Add("Santo Domingo Guzmán");
                txtmunicipio.Items.Add("Sonsonate");
                txtmunicipio.Items.Add("Sonzacate");

            }
            if (txtdepartamento.Text == "Chalatenango")
            {
                txtmunicipio.Items.Add("Agua Caliente");
                txtmunicipio.Items.Add("Arcatao");
                txtmunicipio.Items.Add("Azacualpa");
                txtmunicipio.Items.Add("Chalatenango");
                txtmunicipio.Items.Add("Comalapa");
                txtmunicipio.Items.Add("Citalá");
                txtmunicipio.Items.Add("Concepción Quezaltepeque");
                txtmunicipio.Items.Add("Dulce Nombre de María");
                txtmunicipio.Items.Add("El Carrizal");
                txtmunicipio.Items.Add("El Paraíso");
                txtmunicipio.Items.Add("La Laguna");
                txtmunicipio.Items.Add("La Palma");
                txtmunicipio.Items.Add("La Reina");
                txtmunicipio.Items.Add("Las Vueltas");
                txtmunicipio.Items.Add("Nueva Concepción");
                txtmunicipio.Items.Add("Nueva Trinidad");
                txtmunicipio.Items.Add("Nombre de Jesús");
                txtmunicipio.Items.Add("Ojos de Agua");
                txtmunicipio.Items.Add("Potonico");
                txtmunicipio.Items.Add("San Antonio de la Cruz");
                txtmunicipio.Items.Add("San Antonio Los Ranchos");
                txtmunicipio.Items.Add("San Fernando");
                txtmunicipio.Items.Add("San Francisco Lempa");
                txtmunicipio.Items.Add("San Francisco Morazán");
                txtmunicipio.Items.Add("San Ignacio");
                txtmunicipio.Items.Add("San Isidro Labrador");
                txtmunicipio.Items.Add("San José Cancasque");
                txtmunicipio.Items.Add("San José Las Flores");
                txtmunicipio.Items.Add("San Luis del Carmen");
                txtmunicipio.Items.Add("San Miguel de Mercedes");
                txtmunicipio.Items.Add("San Rafael");
                txtmunicipio.Items.Add("Santa Rita");
                txtmunicipio.Items.Add("Tejutla");
            }

            if (txtdepartamento.Text == "Cuscatlán")
            {
                txtmunicipio.Items.Add("Candelaria");
                txtmunicipio.Items.Add("Cojutepeque");
                txtmunicipio.Items.Add("El Carmen)");
                txtmunicipio.Items.Add("El Rosario");
                txtmunicipio.Items.Add("Monte San Juan");
                txtmunicipio.Items.Add("Oratorio de Concepción");
                txtmunicipio.Items.Add("San Bartolomé Perulapía");
                txtmunicipio.Items.Add("San Cristóbal");
                txtmunicipio.Items.Add("San José Guayabal");
                txtmunicipio.Items.Add("San Pedro Perulapán");
                txtmunicipio.Items.Add("San Rafael Cedros");
                txtmunicipio.Items.Add("San Ramón");
                txtmunicipio.Items.Add("Santa Cruz Analquito");
                txtmunicipio.Items.Add("Santa Cruz Michapa");
                txtmunicipio.Items.Add("Suchitoto");
                txtmunicipio.Items.Add("Tenancingo");

            }
            if (txtdepartamento.Text == "San Salvador")
            {
                txtmunicipio.Items.Add("Aguilares");
                txtmunicipio.Items.Add("Apopa");
                txtmunicipio.Items.Add("Ayutuxtepeque");
                txtmunicipio.Items.Add("Cuscatancingo");
                txtmunicipio.Items.Add("Ciudad Delgado");
                txtmunicipio.Items.Add("El Paisnal");
                txtmunicipio.Items.Add("Guazapa");
                txtmunicipio.Items.Add("Ilopango");
                txtmunicipio.Items.Add("Mejicanos");
                txtmunicipio.Items.Add("Nejapa");
                txtmunicipio.Items.Add("Panchimalco");
                txtmunicipio.Items.Add("Rosario de Mora");
                txtmunicipio.Items.Add("San Marcos");
                txtmunicipio.Items.Add("San Martín");
                txtmunicipio.Items.Add("San Salvador");
                txtmunicipio.Items.Add("Santiago Texacuangos");
                txtmunicipio.Items.Add("Santo Tomás");
                txtmunicipio.Items.Add("Soyapango");
                txtmunicipio.Items.Add("Tonacatepeque");

            }

            if (txtdepartamento.Text == "La Libertad")
            {
                txtmunicipio.Items.Add("Antiguo Cuscatlán");
                txtmunicipio.Items.Add("Chiltiupán");
                txtmunicipio.Items.Add("Ciudad Arce");
                txtmunicipio.Items.Add("Colón");
                txtmunicipio.Items.Add("Comasagua");
                txtmunicipio.Items.Add("Huizúcar");
                txtmunicipio.Items.Add("Jayaque");
                txtmunicipio.Items.Add("Jicalapa");
                txtmunicipio.Items.Add("La Libertad");
                txtmunicipio.Items.Add("Nueva San Salvador");
                txtmunicipio.Items.Add("Nuevo Cuscatlán");
                txtmunicipio.Items.Add("San Juan Opico");
                txtmunicipio.Items.Add("Quezaltepeque");
                txtmunicipio.Items.Add("Sacacoyo");
                txtmunicipio.Items.Add("San José Villanueva");
                txtmunicipio.Items.Add("San Matías");
                txtmunicipio.Items.Add("San Pablo Tacachico");
                txtmunicipio.Items.Add("Talnique");
                txtmunicipio.Items.Add("Tamanique");
                txtmunicipio.Items.Add("Teotepeque");
                txtmunicipio.Items.Add("Talnique");
                txtmunicipio.Items.Add("Zaragoza");

            }
            if (txtdepartamento.Text == "San Vicente")
            {
                txtmunicipio.Items.Add("Apastepeque");
                txtmunicipio.Items.Add("Guadalupe");
                txtmunicipio.Items.Add("San Cayetano Istepeque");
                txtmunicipio.Items.Add("San Esteban Catarina");
                txtmunicipio.Items.Add("San Ildefonso");
                txtmunicipio.Items.Add("San Lorenzo");
                txtmunicipio.Items.Add("San Sebastián");
                txtmunicipio.Items.Add("San Vicente");
                txtmunicipio.Items.Add("Santa Clara");
                txtmunicipio.Items.Add("Santo Domingo");
                txtmunicipio.Items.Add("Nuevo Cuscatlán");
                txtmunicipio.Items.Add("Tecoluca");
                txtmunicipio.Items.Add("Tepetitán");
                txtmunicipio.Items.Add("Verapaz");
             

            }
            if (txtdepartamento.Text == "Cabañas")
            {
                txtmunicipio.Items.Add("Cinquera");
                txtmunicipio.Items.Add("Dolores");
                txtmunicipio.Items.Add("Guacotecti");
                txtmunicipio.Items.Add("Ilobasco");
                txtmunicipio.Items.Add("Jutiapa");
                txtmunicipio.Items.Add("San Isidro");
                txtmunicipio.Items.Add("Sensuntepeque");
                txtmunicipio.Items.Add("Tejutepeque");
                txtmunicipio.Items.Add("Victoria");
              


            }
            if (txtdepartamento.Text == "La Paz")
            {
                txtmunicipio.Items.Add("Cuyultitán");
                txtmunicipio.Items.Add("El Rosario");
                txtmunicipio.Items.Add("Jerusalén");
                txtmunicipio.Items.Add("Mercedes La Ceiba");
                txtmunicipio.Items.Add("Olocuilta");
                txtmunicipio.Items.Add("Paraíso de Osorio");
                txtmunicipio.Items.Add("San Antonio Masahuat");
                txtmunicipio.Items.Add("San Emigdio");
                txtmunicipio.Items.Add("San Francisco Chinameca");
                txtmunicipio.Items.Add("San Juan Nonualco");
                txtmunicipio.Items.Add("San Juan Talpa");
                txtmunicipio.Items.Add("San Juan Tepezontes");
                txtmunicipio.Items.Add("San Luis Talpa");
                txtmunicipio.Items.Add("San Luis La Herradura");
                txtmunicipio.Items.Add("San Miguel Tepezontes");
                txtmunicipio.Items.Add("San Pedro Masahuat");
                txtmunicipio.Items.Add("San Pedro Nonualco");
                txtmunicipio.Items.Add("San Rafael Obrajuelo");
                txtmunicipio.Items.Add("Santa María Ostuma");
                txtmunicipio.Items.Add("Santiago Nonualco");
                txtmunicipio.Items.Add("Tapalhuaca");
                txtmunicipio.Items.Add("Zacatecoluca");


            }
            if (txtdepartamento.Text == "San Miguel")
            {
                txtmunicipio.Items.Add("Carolina");
                txtmunicipio.Items.Add("Chapeltique");
                txtmunicipio.Items.Add("Chinameca");
                txtmunicipio.Items.Add("Chirilagua");
                txtmunicipio.Items.Add("Ciudad Barrios");
                txtmunicipio.Items.Add("Comacarán");
                txtmunicipio.Items.Add("El Tránsito");
                txtmunicipio.Items.Add("Lolotique");
                txtmunicipio.Items.Add("Moncagua");
                txtmunicipio.Items.Add("Nueva Guadalupe");
                txtmunicipio.Items.Add("Nuevo Edén de San Juan");
                txtmunicipio.Items.Add("Quelepa");
                txtmunicipio.Items.Add("San Antonio del Mosco");
                txtmunicipio.Items.Add("San Gerardo");
                txtmunicipio.Items.Add("San Jorge");
                txtmunicipio.Items.Add("San Luis de la Reina");
                txtmunicipio.Items.Add("San Miguel");
                txtmunicipio.Items.Add("San Rafael Oriente");
                txtmunicipio.Items.Add("Sesori");
                txtmunicipio.Items.Add("Uluazapa");
               


            }
            if (txtdepartamento.Text == "Morazán")
            {
                txtmunicipio.Items.Add("Arambala");
                txtmunicipio.Items.Add("Cacaopera");
                txtmunicipio.Items.Add("Chilanga");
                txtmunicipio.Items.Add("Corinto");
                txtmunicipio.Items.Add("Delicias de Concepción");
                txtmunicipio.Items.Add("El Divisadero");
                txtmunicipio.Items.Add("El Rosario");
                txtmunicipio.Items.Add("Gualococti");
                txtmunicipio.Items.Add("Guatajiagua");
                txtmunicipio.Items.Add("Jocoaitique");
                txtmunicipio.Items.Add("Jocoro");
                txtmunicipio.Items.Add("Lolotiquillo");
                txtmunicipio.Items.Add("Meanguera");
                txtmunicipio.Items.Add("Osicala");
                txtmunicipio.Items.Add("Perquín");
                txtmunicipio.Items.Add("San Carlos");
                txtmunicipio.Items.Add("San Fernando");
                txtmunicipio.Items.Add("San Francisco Gotera");
                txtmunicipio.Items.Add("San Isidro");
                txtmunicipio.Items.Add("San Simón");
                txtmunicipio.Items.Add("Sensembra");
                txtmunicipio.Items.Add("Sociedad");
                txtmunicipio.Items.Add("Torola");
                txtmunicipio.Items.Add("Yamabal");
                txtmunicipio.Items.Add("Yoloaiquín");




            }
            if (txtdepartamento.Text == "La Unión")
            {
                txtmunicipio.Items.Add("Anamorós");
                txtmunicipio.Items.Add("Bolivar");
                txtmunicipio.Items.Add("Concepción de Oriente");
                txtmunicipio.Items.Add("Conchagua");
                txtmunicipio.Items.Add("El Sauce");
                txtmunicipio.Items.Add("Intipucá");
                txtmunicipio.Items.Add("La Unión");
                txtmunicipio.Items.Add("Lislique");
                txtmunicipio.Items.Add("Meanguera del Golfo");
                txtmunicipio.Items.Add("Nueva Esparta");
                txtmunicipio.Items.Add("Pasaquina");
                txtmunicipio.Items.Add("Polorós");
                txtmunicipio.Items.Add("San Alejo");
                txtmunicipio.Items.Add("San José");
                txtmunicipio.Items.Add("Santa Rosa de Lima");
                txtmunicipio.Items.Add("Yayantique");
                txtmunicipio.Items.Add("Yucuaiquín");
               




            }
        }

        private void txtnie_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
