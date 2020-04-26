using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class alumnos
    {
        private int id_alumno;
        private int id_registro;
        private int id_nota;
        private int idsalon;

        public int Id_alumno
        {
            get
            {
                return id_alumno;
            }

            set
            {
                id_alumno = value;
            }
        }

        public int Id_registro
        {
            get
            {
                return id_registro;
            }

            set
            {
                id_registro = value;
            }
        }

        public int Id_nota
        {
            get
            {
                return id_nota;
            }

            set
            {
                id_nota = value;
            }
        }

        public int Idsalon
        {
            get
            {
                return idsalon;
            }

            set
            {
                idsalon = value;
            }
        }
    }
}
