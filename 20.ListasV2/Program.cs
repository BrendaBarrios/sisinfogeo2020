using System;
using System.Collections.Generic;

namespace _20.ListasV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista tipo pieza
            List<Piezas>mp =new List<Piezas>();
            Console.WriteLine("-------------------Creando una lista---------------");
            mp.Add(new Piezas(1234,"tuerca de rosca interior"));
            mp.Add(new Piezas(5678,"tornillo de cabeza grande"));
            mp.Add(new Piezas(9876,"bateria 12v"));
           


            //Agregar un rango de elementos

            var proveedor =new List<Piezas>(){
                new Piezas(1111,"tridente"),
                new Piezas(2222,"cables para pasar corriente"),
                new Piezas(3333,"llantas"),
            };
            mp.AddRange(proveedor);
            
            //Usar el metodo foreach integrado en la lista para imprimir su contenido 
            mp.ForEach(p=>Console.WriteLine(p.ToString()));
            Console.WriteLine("\n");

            mp.RemoveAt(mp.Count-1);

            //Insertar un elemento en la segunda posición 
            Console.WriteLine("-----Insertar un elemento en la posición 2-----");
            mp.Insert(1,new Piezas(9909,"Caja de 8 velocidades"));
            mp.ForEach(p=>Console.WriteLine(p.ToString()));
            Console.WriteLine("\n");


            //Buscar  todas las piezas que tengasn la palabra tornillo
            Console.WriteLine("--------Piezas que contienen tornillo-----------");
            var t=mp.FindAll(x=>x.Nombre.Contains("tornillo"));
            t.ForEach(p=>Console.WriteLine(p.ToString()));
            Console.WriteLine("\n");

            
            //Buscar todas la piezas cuyo ID es menor que 5000
            Console.WriteLine("----------Piezas con id mayor  a 5000------------");
            var t1=mp.FindAll(x=>x.Id>5000);
            t1.ForEach(p=>Console.WriteLine(p.ToString()));
            Console.WriteLine("\n");



        }
    }
}
