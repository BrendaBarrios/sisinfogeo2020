using System;
using System.Collections.Generic;
namespace _19.ListasV1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string>mats=new List<string>(){
                "Caculo I",
                "Redacción Avanzada",
                "Introducción a la ingenieria"
            };

            mats.Add("Matematicas Discretas");
            mats.Add("Compiladores e Interpretadores");

            Imprime(mats);

            string[] mopt={
                "Sistemas de Info geo(op)",
                "Seguridad en redes(op)",
                "Topicos selectos(op)"
            };

            mats.AddRange(mopt);
            Imprime(mats);

            //Invertir los elementos de la lista
            mats.Reverse();
            Imprime(mats);

            //Ordenar la lista
            mats.Sort();
            Imprime(mats);

            Console.WriteLine("\n");
            
            //Busca un elemento en una lista
            Console.WriteLine("Buscar una materia que tenga la palabra discretas");
            string mat  = mats.Find(x=>x.Contains("Discretas"));
            Console.WriteLine(mat+ "\n");

            //Buscar todas las  ocurrencias en una lista en base a la condicion
            Console.WriteLine("Buscar una materia que contengan(op)");
            var ms  = mats.FindAll(x=>x.Contains("(op)"));
            //Console.WriteLine(ms);
            Imprime(ms);
        }

        static void Imprime(List<string>lista){
            Console.WriteLine("\n");
            foreach (string m in lista){
                Console.WriteLine(m);
            Console.WriteLine(lista.Count);
                
            }
        }
    }
}
