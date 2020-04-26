using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class partidas
    {
        private int id_partida;
        private string posee_partida;
        private int numero_partida;
        private int folio;
        private int tomo;
        private int libro;
        private string lugar_nacimiento;
        private DateTime fecha_nacimiento;

        public int Id_partida
        {
            get
            {
                return id_partida;
            }

            set
            {
                id_partida = value;
            }
        }

        public string Posee_partida
        {
            get
            {
                return posee_partida;
            }

            set
            {
                posee_partida = value;
            }
        }

        public int Numero_partida
        {
            get
            {
                return numero_partida;
            }

            set
            {
                numero_partida = value;
            }
        }

        public int Folio
        {
            get
            {
                return folio;
            }

            set
            {
                folio = value;
            }
        }

        public int Tomo
        {
            get
            {
                return tomo;
            }

            set
            {
                tomo = value;
            }
        }

        public int Libro
        {
            get
            {
                return libro;
            }

            set
            {
                libro = value;
            }
        }

        public string Lugar_nacimiento
        {
            get
            {
                return lugar_nacimiento;
            }

            set
            {
                lugar_nacimiento = value;
            }
        }

        public DateTime Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }

            set
            {
                fecha_nacimiento = value;
            }
        }
    }
}
