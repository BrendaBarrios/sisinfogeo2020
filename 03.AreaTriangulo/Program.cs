using System;

namespace _03.AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double labase,elaltura,elarea;
            Console.WriteLine("Calcula area del triangulo");
            Console.WriteLine("Dame la base:");
            labase=double.Parse(Console.ReadLine());
            Console.WriteLine("Dame la altura:");
            elaltura=double.Parse(Console.ReadLine());

            elarea=(labase*elaltura)/2;
            Console.WriteLine($"El area del triangulo{elarea}");
            Console.ReadLine();


        }
    }
}
