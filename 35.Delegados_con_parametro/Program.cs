using System;

namespace _35.Delegados_con_parametro
{
    public delegate void  MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado del; // Se crea instancia de MiDelegado

            Console.Clear();

            del=ClaseA.MetodoA;
            InvocaDelegado(del);

            del=ClaseB.MetodoB;
            InvocaDelegado(del);

            del = (string msj) => Console.WriteLine($"Llamando expresión Lambada : {msj}");
            InvocaDelegado(del);

            Console.WriteLine();
            }

            static void InvocaDelegado(MiDelegado del){
                del("Hola Mundo");
            }
        }

    class ClaseA{
        public static void MetodoA(string msj){
            Console.WriteLine($"Llamando MetodoA de ClaseA : {msj}");
        }
    }

    class ClaseB{
        public static void MetodoB(string msj){
            Console.WriteLine($"Llamando MetodoA de ClaseAB: {msj}");
        }
    }
}


