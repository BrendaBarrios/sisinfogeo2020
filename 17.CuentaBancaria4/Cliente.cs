using System;
using System.Collections.Generic;

namespace _14.CuentaBancaria
{
    [Serializable()]
    class Cliente
    {
        private List<CuentaBancaria> cuentas;
        private string nombre;

        public Cliente(string nombre)
        {
            this.nombre=nombre;
            cuentas = new List<CuentaBancaria>();

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public List <CuentaBancaria> Cuenta
        {
            get { return cuentas; }
        }
        public void AgregarCuenta(CuentaBancaria cta)
        {
            cuentas.Add(cta);
        }
        
    }
}