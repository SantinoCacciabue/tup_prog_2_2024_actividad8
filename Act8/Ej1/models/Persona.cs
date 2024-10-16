using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Persona:IComparable
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public Persona(int dni, string nombre)
        {
            DNI = dni;
            Nombre = nombre;
        }

        public int CompareTo(object obj)
        {
            Persona p = (Persona)obj;
            if (p != null)
            {
                return DNI.CompareTo(p.DNI);

            }
            return -1;
        }
    }
}
