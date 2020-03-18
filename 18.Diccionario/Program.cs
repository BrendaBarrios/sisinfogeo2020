using System;
using  System.Collections.Generic;

namespace _18.Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definimos el diccionario y reservamos espacion en memoria para el.
            //Dictionary<string,string>midic= new Dictionary<String,string>();
            SortedDictionary<string,string>midic= new SortedDictionary<String,string>(); //coloca en orden los parametros.

            //Agregar entradas al diccionario
            midic.Add(" txt" ,"archivo de texto");
            midic.Add("jpg","archivo de imagen");
            midic.Add(" mp3" ,"archivo de sonido");
            midic.Add("html","archivo de html");
            midic.Add(" exe" ,"archivo de ejecucion windows");
            midic.Add("cc","archivo de tipo descnocido");

            //Acceder un elemento en base a la llave
            Console.WriteLine(midic["html"]);

            //Verificar si una llave existe,si no agregarla
            if (midic.ContainsKey("elf"))
                Console.WriteLine("La llave ya existe");
            else
            {
                midic.Add("elf","Archivo ejecutable de Linux");
            }
        
            //Borrar una entrada si la llave existe
            if(midic.ContainsKey("lll"))
                midic.Remove("lll");


            //Modificar un valor en base ala llave
            midic["htm"]="Archivo de texto HTML";
            
            //Recorro el diccionario  e imprimo la llave y su valor
            Console.WriteLine("----------Elementos del diccionario--------------------\n");
            foreach (KeyValuePair<string,string>val in midic){
                
                Console.WriteLine($" {val.Key} - {val.Value}\n");
            }

            //Imprimir solo las llaves
            Console.WriteLine("-------------Imprimiendo solo las llave del diccionario--------------\n");
            foreach (string llave in midic.Keys)
            {
                Console.WriteLine(llave +"\n");
            }

               //Imprimir solo los valores del diccionario
            Console.WriteLine("-------------Imprimiendo solo los valores--------------\n");
            foreach (string valor in midic.Values)
            {
                Console.WriteLine(valor+"\n");
            }

            //Borrar todas las entradas al diccionario
            midic.Clear();

        }
    }
}
