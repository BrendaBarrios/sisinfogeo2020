using System;
using System.Threading;

namespace _30.Threading4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hilo principal iniciado !");

            //Crea Threads con nombre
            Thread t1 = new Thread(Metodo1){Name= "Cliente1"};
            Thread t2 = new Thread(Metodo2){Name= "Cliente2"};
            Thread t3 = new Thread(Metodo3){Name= "Cliente3"};

            //Ejecutan métodos
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Hilo principal terminado !");

        }

        static void Metodo1(){
            Console.WriteLine("Método 1 Iniciado usando " + Thread.CurrentThread.Name);
            for (int i=1; i<= 5 ; i++)
                Console.WriteLine("Metodo1: " + i);
            Console.WriteLine("Método 1 terminado usando " + Thread.CurrentThread.Name);
        }

        
        static void Metodo2(){
            Console.WriteLine("Método 2 Iniciado usando " + Thread.CurrentThread.Name);
            for (int i=1; i<= 5 ; i++)
                Console.WriteLine("Metodo 2: " + i);
            Console.WriteLine("Método 2 terminado usando " + Thread.CurrentThread.Name);
        }

        
        static void Metodo3(){
            Console.WriteLine("Método 3 Iniciado usando " + Thread.CurrentThread.Name);
            for (int i=1; i<= 5 ; i++){
                Console.WriteLine("Método3: " + i);
                if(i==3){
                    Console.WriteLine("Iniciando Operación sobre la base de datos ");
                    Thread.Sleep(10000);
                    Console.WriteLine("Operación sobre la base de datos terminada ");
                }

            }
            Console.WriteLine("Método 3 terminado usando  " + Thread.CurrentThread.Name);
        }
    }
}
