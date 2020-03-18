using System;
using System.Linq;
using System.Collections.Generic;

namespace _21.Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Fuente de datos

           int[] numeros= new int[]{
                10,20,30,40,50,60,70,80,90,100, 
                -10,-20,-30,-40,-50,-60,-70,-80,-90,-100, 
                10,20,30,40,50,60,70,80,90,100, 
                -10,-20,-30,-40,-50,-60,-70,-80,-90,-100,1000,2000,3000 
           };

            // Crear consulta obtuvimos impares ,regresa un Ienumerable<in>
            Console.WriteLine("\n");
           
            var consulta   = 
                from num in numeros
                where (num%2==0)
                select num;

            //Ejecutar consulta
            foreach(var num in consulta){
                Console.Write($"{num} ");
            }

            // Consulta 2, impares no negativos ,ni ceros, en un arreglo regresa un arreglo de emteros
            ;
            var consulta2   = 
                (from num in numeros
                where num>=10 && num >=200
                select num).ToArray();

            Console.WriteLine();
            Console.WriteLine("\n");
           

            Console.WriteLine("Numeros mayore a 100");
            for(int i=0; i<consulta2.Count();i++){
                Console.Write($"{consulta2[i]} ");
            }
           

            var consulta3   = 
                (from num in numeros
                where num>0
                select num).ToList();

            Console.WriteLine();

            Console.WriteLine("\n Numero negativos :");
            
            consulta3.ForEach(num=>Console.Write($"{num} ")); 
            Console.WriteLine("\n");
           

        }







    }
}
