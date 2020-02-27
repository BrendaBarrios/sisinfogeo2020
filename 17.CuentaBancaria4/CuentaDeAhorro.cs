using System;
namespace _14.CuentaBancaria
{
    [Serializable()]
    class CuentaDeAhorro : CuentaBancaria //heredamos de cuenta bancaria se denota por  : 
    {
        private double tasaInteres;

        public CuentaDeAhorro(double saldo,double tasaInteres)
        //llamada explicita al constructor clase base
            : base(saldo) 
        {
            this.tasaInteres=tasaInteres;
        }
        public void CalcularInteres()
        {
            saldo+= (saldo*tasaInteres);
        }
    }
}