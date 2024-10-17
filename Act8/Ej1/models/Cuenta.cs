using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Cuenta:IComparable
    {
        public Persona Titular { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public DateTime Fecha { get; set; }
        public Cuenta(int num, Persona p)
        {
            Titular = p;
            Numero = num;
        }
        public Cuenta(int num, double saldo,DateTime fecha,Persona p)
        {
            Numero = num;   
            Saldo = saldo;
            Titular = p;
            Fecha = fecha;

        }

        public int CompareTo(object obj)
        {
            Cuenta c = obj as Cuenta;
            if (c != null)
            {
                return Numero.CompareTo(c.Numero);
            }
            return -1;
        }
        public override string ToString()
        {
            return $"Nombre: {Titular.Nombre}-({Titular.DNI}) Num:{Numero}(${Saldo})";
        }
    }
}
