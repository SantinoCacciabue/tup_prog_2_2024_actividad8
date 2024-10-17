using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Banco
    {
        private List<Persona> clientes = new List<Persona>();
        public List<Cuenta> cuentas = new List<Cuenta> ();
        public int CantidadCuentas
        {
            get
            {
                return cuentas.Count;
            }
        }
        public int CantidadClientes
        {
            get
            {
                return clientes.Count;
            }
        }
        public Cuenta this[int i]
        {
            get
            {
                return cuentas[i];
            }
        }
        public Cuenta AgregarCuenta(int num,int dni, string nom)
        {
            Persona p = (VerClientePorDNI(dni));
            if(p== null)
            {
                p = new Persona(dni, nom);
                clientes.Add(p);
            }
            Cuenta c = VerCuentaPorNumero(num);
            if(c== null)
            {
                c = new Cuenta(num, p); 
                cuentas.Add(c);
            }
            else
            {
                throw new Exception("re mal");
            }
           
            return c;
        }
        public Cuenta VerCuenta(int i)
        {
            return cuentas[i];
        }
        public Cuenta VerCuentaPorNumero(int numero)
        {
            foreach(Cuenta c in cuentas)
            {
                if (c.Numero == numero)
                {
                    return c;
                }                   
            }
            return null;

        }
        public Persona VerClientePorDNI(int dni)
        {
            foreach(Persona p in clientes)
            {
                if(p.DNI == dni)
                {
                    return p;
                }
            }
            return null;
        }
        public bool RestaurarCuenta(int num,double saldo, DateTime fecha, Persona p)
        {
            cuentas.Sort();
            int i = cuentas.BinarySearch(new Cuenta(num, saldo, fecha, p));
            if (i == -1)
            {
                return false;
            }
            return true;

        }
    }
}
