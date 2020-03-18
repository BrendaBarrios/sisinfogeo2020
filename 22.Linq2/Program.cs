using System;
using System.Linq;

namespace _22.Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas= new string[]{
                "pera","melon","sandia","papaya","durazno","platano",
                "manzana","kiwi","pitayas","mango","cereza"
            };

            // ontiene las frutas con m.
            var qr1= 
                from fruta in frutas 
                where fruta.StartsWith("m")
                select fruta;
            
            foreach(string f in qr1)
                Console.WriteLine(f);
            Console.WriteLine($"Total:{qr1.Count()}");

            Console.WriteLine("\n");

            var qr2= 
                (from fruta in frutas 
                where fruta.Contains("an")
                select fruta).ToList();
            qr2.ForEach(f=>Console.WriteLine(f));
            Console.WriteLine($"Total:{qr1.Count()}");

            Console.WriteLine("\n");

        }
    }
}
