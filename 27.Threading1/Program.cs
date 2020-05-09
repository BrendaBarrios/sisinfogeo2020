using System;
using System.Threading;

namespace _27.Threading1
{
    class program{
        static void Main(string[] args){

            //Nombre del thread principal.
            Thread.CurrentThread.Name="Principal";

            //Creamos dos threads
            Thread t1 = new Thread(Imprime);
            Thread t2 = new Thread(Imprime);

            //Damos un nombre a los thread que creamos
            t1.Name="Thread1";
            t2.Name="Thread2";

            // Invocams los threads
            t1.Start();
            t2.Start();
        
            //Invocamosimprime desde el thread principal.
            Imprime();

            Console.WriteLine("Saludos desde MAIN , se ha terminado todo");

        }

        static void Imprime(){
            for (int i=0; i<10; i++){
                Console.WriteLine($"Imprime.{i} desde {Thread.CurrentThread.Name}");
                Thread.Sleep(100);
            }
        }
    }
    
}
