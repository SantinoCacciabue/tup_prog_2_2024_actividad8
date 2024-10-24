using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    [Serializable]
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
                c = new Cuenta(num, p);//se crea la cuenta con saldo 0(en el form se le agrega saldo).
                cuentas.Add(c);
            }           
            return c;
        }
        public Persona VerCliente(int i)
        {
            return clientes[i];
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
            Cuenta c = new Cuenta(num, saldo, fecha, p);
            cuentas.Sort();
            int i = cuentas.BinarySearch(c);

            if (i >= 0)
            {
                return false;
            }
            cuentas.Add(c);
            return true;

        }
    }
}
