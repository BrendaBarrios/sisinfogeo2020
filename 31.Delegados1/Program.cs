// Ejemplo de delegados simple
using System;

namespace _31.Delegados1
{
    public delegate void MiDelegado(string msj);

    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d; //Se instancia el delegado

            Console.Clear();

            //Delegado invoca al método Mensaje2  de la clase mensajes
            d =  Mensajes.Mensaje1;
            d("juan");

            //Delegado invoca al metodo mensaje2 de la clase mensajes
            d =  Mensajes.Mensaje2;
            d("jose");

            //Delegado invoca al metodo mensaje 2 de la clase mensajes
            d = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d("Brenda");
            
            Console.WriteLine();
        }
    }

        public class Mensajes{
            public static void Mensaje1(string msj){
                Console.WriteLine($"{msj} - lleva el pastel");
            }
            public static void Mensaje2(string msj){
                Console.WriteLine($"{msj} - fue el culpable se cancela la fiesta");
        }
    }
}

