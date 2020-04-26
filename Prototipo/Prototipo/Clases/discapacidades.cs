using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class discapacidades
    {
        private int id_discapacidad;
        private string tipo_discapacidad;
        private string recibe_edu_especial;

        public int Id_discapacidad
        {
            get
            {
                return id_discapacidad;
            }

            set
            {
                id_discapacidad = value;
            }
        }

        public string Tipo_discapacidad
        {
            get
            {
                return tipo_discapacidad;
            }

            set
            {
                tipo_discapacidad = value;
            }
        }

        public string Recibe_edu_especial
        {
            get
            {
                return recibe_edu_especial;
            }

            set
            {
                recibe_edu_especial = value;
            }
        }
    }
}
