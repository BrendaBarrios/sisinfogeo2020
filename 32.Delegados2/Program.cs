using System;

namespace _32.Delegados2
{
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            // Se declaran tres delegados

            MiDelegado d1;
            MiDelegado d2;
            MiDelegado d3; 
            
            MiDelegado d; //Se declara delegado multicast

            Console.Clear();

            // Se asocia d1 a Mensaje y d2 a Mensaje2
            d1 = Delegados.Mensaje1;
            d2 = Delegados.Mensaje2;

            d = d1 + d2; //Combina delegadod1 y delegado d2
            d("El peje");
            Console.WriteLine();

            d3 = (string msj) => Console.WriteLine($"{msj} - paga todo pero que no pare la fiesta");
            d += d3; // Agrega delegado d3.
            d("El borolass");
            Console.WriteLine();

            d -=d2;//Quita el delegado d2.
            d("Peña");
            Console.WriteLine();

            d -=d1;//Quita el delegado d2.
            d("Tello");
            Console.WriteLine();

        }
    }
}
