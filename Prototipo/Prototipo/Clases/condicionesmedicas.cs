using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo.Clases
{
    class condicionesmedicas
    {
        private int id_condicion;
        private string vacunascompletas;
        private string problema_salud;
        private string tipo_problema;

        public int Id_condicion
        {
            get
            {
                return id_condicion;
            }

            set
            {
                id_condicion = value;
            }
        }

        public string Vacunascompletas
        {
            get
            {
                return vacunascompletas;
            }

            set
            {
                vacunascompletas = value;
            }
        }

        public string Problema_salud
        {
            get
            {
                return problema_salud;
            }

            set
            {
                problema_salud = value;
            }
        }

        public string Tipo_problema
        {
            get
            {
                return tipo_problema;
            }

            set
            {
                tipo_problema = value;
            }
        }
    }
}
