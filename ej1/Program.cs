using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1
{
 class Program
    {
        static void Main(string[] args)
        {
        // Instanciación de una clase
        // y reservar su espacio en memoria
        empleado empleado01 = new empleado();
        empleado empleado03 =new empleado("Maria",28);
        // Instanciación de una clase y
        // posteriormente resarvar su espacio en memoria
        empleado empleado02;
        empleado02 = new empleado();

        empleado01.Nombre="Brenda";
        empleado01.Edad=20;

        empleado02.Nombre="Yasmin";
        empleado02.Edad=20;

        Console.WriteLine($"Nombre : {empleado01.Nombre} ,Edad:{empleado01.Edad}");
        Console.WriteLine(empleado01.ToString());

        Console.WriteLine($"Te vas de vacaciones{DateTime.Now.ToString("dd/MM/yy")}");
        Console.WriteLine($"Regresas:{empleado01.Vacaciones(DateTime.Now,16)}");
        Console.WriteLine(empleado01.Vacaciones(DateTime.Now,1));

        }
    }
}
