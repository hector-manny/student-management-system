using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo
{
    class usuarios
    {
        private string usuario;
        private string contraseña;
        private string TipoUsuario;

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public string TipoUsuario1
        {
            get
            {
                return TipoUsuario;
            }

            set
            {
                TipoUsuario = value;
            }
        }
    }
}
