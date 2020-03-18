using System;
using System.Collections.Generic;
using System.Linq;

namespace _23.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Estudiante> grupo=new List<Estudiante>();

           grupo.Add(new Estudiante {Id=1234,Nombre="Jose",
                                    Ciudad="Zacatecas",Calle="1a de Mayo",
                                    Cals=new List<int>{90,80,70,60}});

            grupo.Add(new Estudiante {Id=4444,Nombre="Maria",
                                    Ciudad="Zacatecas",Calle="1a de Mayo",
                                    Cals=new List<int>{90,70,70,60}});

            grupo.Add(new Estudiante {Id=5555,Nombre="Maria",
                                    Ciudad="Fresnillo",Calle="Benito Juarez",
                                    Cals=new List<int>{70,70,70,60}});

            grupo.Add(new Estudiante {Id=7777,Nombre="Maria",
                                    Ciudad="Fresnillo",Calle="1a de Mayo",
                                    Cals=new List<int>{70,70,70,60}});
        
        // Imprimit todos los datos
        Console.WriteLine("\n Todo los datos: \n ");
        grupo.ForEach(Estudiante=> Console.WriteLine(Estudiante.ToString()));

        
        var q1 =(from est in grupo orderby est.Nombre select  est).ToList();
        Console.WriteLine("\n  Todo ordenado por nombre: \n ");
        q1.ForEach(est=> Console.WriteLine(est.ToString()));


        var q2 =(from est in grupo orderby est.Ciudad=="Zacatecas" select  est).ToList();
        Console.WriteLine("\n Nadamas los de zacatecas: \n ");
        q2.ForEach(est=> Console.WriteLine(est.ToString()));

        var q3 =
            (from est in grupo 
            select new {nombre =est.Nombre,promedio =est.Cals.Average()}).ToList();
        Console.WriteLine("\n Nombre y promedio de los mayores de 70:\n ");
        q3.ForEach(est=> Console.WriteLine($"Nombre{est.nombre}, Promedio{est.promedio}"));
        
        //Agregar por cuidad
        var q4= from est in grupo group est by est.Ciudad;
        Console.WriteLine("\n Estudiantes agrupados por ciudad:\n ");
       foreach(var ciudad in q4){
           Console.WriteLine(ciudad.Key);
            
           foreach (var est in ciudad){
            Console.WriteLine(est.ToString());               
           }
       }
        

        }  
        
    }
}
