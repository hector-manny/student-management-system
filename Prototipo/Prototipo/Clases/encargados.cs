using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class encargados
    {
        private int id_encargado;
        private string nombre;
        private string grado_de_estudio;
        private string parentezco;
        private string sabe_leeres;

        public int Id_encargado
        {
            get
            {
                return id_encargado;
            }

            set
            {
                id_encargado = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Grado_de_estudio
        {
            get
            {
                return grado_de_estudio;
            }

            set
            {
                grado_de_estudio = value;
            }
        }

        public string Parentezco
        {
            get
            {
                return parentezco;
            }

            set
            {
                parentezco = value;
            }
        }

        public string Sabe_leeres
        {
            get
            {
                return sabe_leeres;
            }

            set
            {
                sabe_leeres = value;
            }
        }
    }
}
