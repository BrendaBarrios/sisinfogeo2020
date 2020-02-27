using System;
namespace _14.CuentaBancaria
{
    [Serializable()]
    class CuentaDeCheches : CuentaBancaria
    {
        private double proteccionSobreGiro;


        public CuentaDeCheches(double saldo, double proteccionSobreGiro)
            :base (saldo)
        {
            this.proteccionSobreGiro=proteccionSobreGiro;
        }
        public override bool Retira(double cant)
        {
            if(cant>saldo)
            {
                double proteccionRequerida = cant-saldo;
                if(proteccionSobreGiro<proteccionRequerida)
                    return false;
                else
                {
                    saldo=0.0;
                    proteccionSobreGiro-=proteccionRequerida;
                }
            }else
            {
                saldo-=cant;
                return true;
            }
            return true;
        }
    }
}