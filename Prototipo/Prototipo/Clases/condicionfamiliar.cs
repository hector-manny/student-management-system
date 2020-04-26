using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class condicionfamiliar
    {

        private int id_condicionfa;
        private string tipo_condicion;

        public int Id_condicionfa
        {
            get
            {
                return id_condicionfa;
            }

            set
            {
                id_condicionfa = value;
            }
        }

        public string Tipo_condicion
        {
            get
            {
                return tipo_condicion;
            }

            set
            {
                tipo_condicion = value;
            }
        }
    }
}
