using System;

namespace _05.pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            if(args.Length==0){
                Menu();
                return 1;
            }

            char tam=char.Parse(args[0]);
            string [] ing = args[1].Split("+");//agarrar todos los ingredientes y los descompone
            char cub = char.Parse(args[2]);
            char don = char.Parse(args[3]);

            string tamano = "",ingredientes="",cubierta="",donde="";
            if(tam=='P'){
                tamano="Pequena";

            }else if(tam=='M'){
                tamano="Mediana";

            }else{
                tamano="Grande";
            }
            foreach (string i in ing){
                switch (char.Parse(i))
                {
                    case 'E': ingredientes += "Extra Queso, ";break;
                    case 'C': ingredientes += "Champiniones, ";break;
                    case 'T': ingredientes += "Tomates, ";break;
                    case 'P': ingredientes += "Pina, ";break;
                }
            }
            if(cub=='D'){
                cubierta="Delgada";

            }else{
                cubierta="Gruesa";
            }

            if(don=='C'){
                donde="Comer aqui";

            }else{
                donde="Para llevar";
            }
            Console.Clear();
            Console.WriteLine($"Tamaño      : {tamano}");
            Console.WriteLine($"Ingredientes: {ingredientes}");
            Console.WriteLine($"Cubierta    : {cubierta}");
            Console.WriteLine($" Donde      : {donde}\n\n");

            return 0;
            
        }
        static void Menu(){
                Console.WriteLine("Procesando Pizzas \n");
                Console.WriteLine("Tamaño     : (P)equeña, (M)ediana o (G)rande.");
                Console.WriteLine("Ingredientes: (E)xtra Queso, (C)hampiñones,(T)omates, (P)ina.");
                Console.WriteLine("Cubierta: (D)elgada o (G)ruesa");
                Console.WriteLine(" Donde se consume: (C)omer aquí o (P)ara Llevar.\n\n");
                Console.WriteLine("<Tamano><ing1+ing2...><Cubierta><Donde>");

            }
    }
}