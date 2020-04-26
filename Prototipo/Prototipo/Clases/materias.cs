using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class materias
    {
        private int id_materia;
        private string asignatura;
        private string codigomateria;

        public int Id_materia
        {
            get
            {
                return id_materia;
            }

            set
            {
                id_materia = value;
            }
        }

        public string Asignatura
        {
            get
            {
                return asignatura;
            }

            set
            {
                asignatura = value;
            }
        }

        public string Codigomateria
        {
            get
            {
                return codigomateria;
            }

            set
            {
                codigomateria = value;
            }
        }
    }
}
