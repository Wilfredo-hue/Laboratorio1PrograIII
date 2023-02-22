using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1_PrograIII
{
    public abstract class Persona
    {
        private string nombre;
        private int edad;
        private Departamento departamento;
        private Municipio municipio;


        public int Nombre
        {
            get => Edad;
            set => Edad = value;
        }
        public int Edad
        { 
            get => Edad;
            set => Edad = value; 
        }
        public Departamento Departamento 
        { 
            get => departamento; 
            set => departamento = value;
        }
        public Municipio Municipio 
        { 
            get => municipio; 
            set => municipio = value;
        }

    }
}
