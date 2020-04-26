using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class direcciones
    {
        private int id_direccion;
        private string departamento;
        private string municipio;
        private string zona;
        private string complemento;

        public int Id_direccion
        {
            get
            {
                return id_direccion;
            }

            set
            {
                id_direccion = value;
            }
        }

        public string Departamento
        {
            get
            {
                return departamento;
            }

            set
            {
                departamento = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string Zona
        {
            get
            {
                return zona;
            }

            set
            {
                zona = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }
    }
}
