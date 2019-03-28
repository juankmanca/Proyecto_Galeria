using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeria
{
    class Persona
    {

    
        private string cedula, nombre;

        public Persona( string cedula, string nombre)
        {
           
            this.Cedula = cedula;
            this.Nombre = nombre;
        }

     
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
