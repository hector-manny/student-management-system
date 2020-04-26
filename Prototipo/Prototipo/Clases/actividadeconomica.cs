using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class actividadeconomica
    {
        private int id_actividadecono;
        private string tipo_actividad;

        public int Id_actividadecono
        {
            get
            {
                return id_actividadecono;
            }

            set
            {
                id_actividadecono = value;
            }
        }

        public string Tipo_actividad
        {
            get
            {
                return tipo_actividad;
            }

            set
            {
                tipo_actividad = value;
            }
        }
    }
}
