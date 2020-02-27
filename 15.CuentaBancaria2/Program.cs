using System;

namespace _14.CuentaBancaria
{
    class Program
    {
        static void PruebaCuentaBancaria()
        {
            CuentaBancaria chelines = new CuentaBancaria(1000);
            Console.WriteLine($"Saldo al crear {chelines.Saldo}");

            chelines.Deposita(500);
            Console.WriteLine($"Saldo despues de mi domingo {chelines.Saldo}");

            if(chelines.Retira(2500))
                Console.WriteLine($"Saldo despues de la peda {chelines.Saldo}");
            else
                Console.WriteLine("No puedes andar organizando fiestas si no tienes dinero");
        }
        static void PruebaCliente()
        {
            //Creamos dos objetos tipo cliente
            Cliente c1 = new Cliente("Juan Perez");
            Cliente c2 = new Cliente("Paola Torres");
            Cliente c3 = new Cliente("Eduardo Torres");
            //Creo objeto tipo cuenta 
            CuentaBancaria cuenta1 =new CuentaBancaria(100);
            //Creo objeto tipo cliente y le asigno la cuenta creada
            c1.Cuenta=cuenta1;
            c1.Cuenta.Deposita(500);
            //Asigno directamente una nueva cuenta bancaria al cliente exitente numero 2.
            c2.Cuenta=new CuentaBancaria(200);
            c3.Cuenta=c2.Cuenta;
            c2.Cuenta.Retira(50);
            c3.Cuenta.Deposita(100);

            Console.WriteLine($"Cliente {c1.Nombre} tiene un saldo de {c1.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {c2.Nombre} tiene un saldo de {c2.Cuenta.Saldo}");
            Console.WriteLine($"Cliente {c3.Nombre} tiene un saldo de {c3.Cuenta.Saldo}");
        }
        static void Main()
        {
            Banco mibanco = new Banco("Mis chelines","Yo mera");
            mibanco.AgregarCliente(new Cliente("Genaro Boregon"));
            mibanco.AgregarCliente(new Cliente("Arturo Romo"));
            mibanco.AgregarCliente(new Cliente("Ricardo Monreal"));
            mibanco.AgregarCliente(new Cliente("Miguel Alonso"));
            mibanco.AgregarCliente(new Cliente("Amalia Garcia"));
            mibanco.AgregarCliente(new Cliente("Alejandro Tello"));

            mibanco.Clientes[0].Cuenta = new CuentaBancaria(15000);
            mibanco.Clientes[1].Cuenta = new CuentaBancaria(25000);
            mibanco.Clientes[2].Cuenta = new CuentaBancaria(35000);
            mibanco.Clientes[3].Cuenta = new CuentaBancaria(45000);
            mibanco.Clientes[4].Cuenta = new CuentaBancaria(55000);
            mibanco.Clientes[5].Cuenta = new CuentaBancaria(105000);

            mibanco.Clientes[2].Cuenta.Retira(15000);
            mibanco.Clientes[5].Cuenta.Retira(25000);
            mibanco.Clientes[4].Cuenta.Deposita(25000);

            foreach (Cliente cte in mibanco.Clientes)
            {
                Console.WriteLine($"CLiente: {cte.Nombre}, Saldo: {cte.Cuenta.Saldo} ");
            }


        }
    }
    
}

