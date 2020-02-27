namespace _14.CuentaBancaria
{
    class CuentaBancaria
    {
        //permite que sea accedido por las clasesque heredan
        protected double saldo;

        public CuentaBancaria(double saldo)
        {
            this.saldo=saldo;
        }
        public double Saldo
        {

            get {return saldo;}
        }
        //propiedad de sololectura 
        public void Deposita(double cantidad)
        {
            saldo+=cantidad;
        }
        //metodo vitual que podra ser sobrecargado por la clase que lo herede
        public virtual bool Retira(double cant)
        {
            if(saldo>=cant)
            {
                saldo-=cant;
                return true;
            }else return false;
        }
    }
}