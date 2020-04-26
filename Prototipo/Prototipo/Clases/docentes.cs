using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class docentes
    {
        private int id_docente;
        private string primernombre;
        private string segundonombre;
        private string primerapellido;
        private string segundoapellido;
        private int edad;
        private int telefono;
        private int NIP;
        private string asignatura_impartida;

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

        public string Primernombre
        {
            get
            {
                return primernombre;
            }

            set
            {
                primernombre = value;
            }
        }

        public string Segundonombre
        {
            get
            {
                return segundonombre;
            }

            set
            {
                segundonombre = value;
            }
        }

        public string Primerapellido
        {
            get
            {
                return primerapellido;
            }

            set
            {
                primerapellido = value;
            }
        }

        public string Segundoapellido
        {
            get
            {
                return segundoapellido;
            }

            set
            {
                segundoapellido = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                edad = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int NIP1
        {
            get
            {
                return NIP;
            }

            set
            {
                NIP = value;
            }
        }

        public string Asignatura_impartida
        {
            get
            {
                return asignatura_impartida;
            }

            set
            {
                asignatura_impartida = value;
            }
        }
    }
}
