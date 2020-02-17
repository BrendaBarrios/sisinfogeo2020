using System;

namespace _06.Tablas
{
    //Descripción : Debes elegir la opción 1 para imprimir una tabla de 
    //multiplicar específica hasta cierto número (ej.op 1 la tabla del 5 , del 1 al 10).
    //Para ejecutarlo deberas colocar *****dotnet run 1 5 1 10
    // Debes elegir la opción 2 : Imprimir las tablas deseadas hasta el número deseado. (ej. hasta la table del 5, del 1 al 11) 
    //Para ejecutarlo deberas colocar *****dotnet run 2 5 1 22
    
    class Program
    {
        static int Main(string[] args)
        {

          
          
            int op=0;//Variable para la opción del menu.
            

           if(args.Length==1){
                Menu();
                return 1;
           }
           int tablaF=char.Parse(args[1]);//Indica la tabla deseada.
           op=int.Parse(args[0]);//Indica el número de la acción a realizar.
            int rango=0;//Indica hasta que numero será multiplicada.



            switch (op){
                case 1:{
                  
                    for(tablaF=int.Parse(args[1]);tablaF<=int.Parse(args[1]);tablaF+=1){
                        for(rango=int.Parse(args[2]);rango<=int.Parse(args[3]);rango+=1){
                            Console.WriteLine($"{tablaF} X {rango} = {tablaF*rango}");
                        }
                        Console.WriteLine("");

                    }
                }break;

                case 2:{
                    for(tablaF=1;tablaF<=int.Parse(args[1]);tablaF+=1){
                        for(rango=int.Parse(args[2]);rango<=int.Parse(args[3]);rango+=1){
                            Console.WriteLine($"{tablaF} X {rango} = {tablaF*rango}");
                        }
                        Console.WriteLine("");
                    }
                }break;
            }

            return 1;
        }

         static void Menu()
        {
            Console.WriteLine("Tablas de multiplicar");
            Console.WriteLine("[1]. Coloca 1 argumento realiza de 1 hasta la tabla ");
            Console.WriteLine("[2]. Coloca 3 argumento el primero indica la tabla y los siguientes dos el rango");
        }

        
    }
}
