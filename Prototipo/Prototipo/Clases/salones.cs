using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class salones
    {
        private int Id_salon;
        private string grado;
        private string seccion;
        private int capacidad;
        private int id_docente;
        private int id_alumno;

        public int Id_salon1
        {
            get
            {
                return Id_salon;
            }

            set
            {
                Id_salon = value;
            }
        }

        public string Grado
        {
            get
            {
                return grado;
            }

            set
            {
                grado = value;
            }
        }

        public string Seccion
        {
            get
            {
                return seccion;
            }

            set
            {
                seccion = value;
            }
        }

        public int Capacidad
        {
            get
            {
                return capacidad;
            }

            set
            {
                capacidad = value;
            }
        }

        public int Id_docente
        {
            get
            {
                return id_docente;
            }

            set
            {
                id_docente = value;
            }
        }

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
    }
}
