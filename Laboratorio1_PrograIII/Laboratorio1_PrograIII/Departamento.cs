using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_PrograIII
{
    public  class Departamento : Municipio
    {
        private string nombre;
        private Municipio municipio;

        public string Nombre
        {
            get => Nombre; 
            set => Nombre = value; 
        }
        public string Municipio 
        { 
            get => Municipio;
            set => Municipio = value;
        }
    }
}
