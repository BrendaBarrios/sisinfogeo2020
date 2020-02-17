/*
 * AUTOR : Brenda Yasmin Barrios Becerra.
 * OBJETIVO : Almcena los elementos de forma inversa.
*/


using System;

namespace _11.vectorInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX=15;
            double[]A =new double[MAX];
            double[]B =new double[MAX];
            Random aleatorio= new Random();

            //Generar numeros aleatorios y guardarlos en un vector

            for(int i=0;i<MAX;i++){
                //Se guarda el arreglo original.
                A[i]=aleatorio.Next(10,50);
            }

            //Guardando datos en el arreglo
            int posAregloB=B.Length-1;
            for(int i=0;i<A.Length;i++){
                B[posAregloB-i]=A[i];
            }

            Console.WriteLine("Este es el vector original \n");
            imprime(A);
            Console.WriteLine("Este es el vector a la inversa \n");
            imprime(B);
            
        }
         
        //Imprime vector original
        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} ");
            
            }
            Console.WriteLine();
        }   
        
        //Imprimir vector a la inversa(Este método no es utilizado en esta clase).
        static void imprimeInversa(double[] v){
            for(int i=v.Length-1;i>=0;i--){
                Console.Write($"{v[i]} ");
            
            }
            Console.WriteLine();
        }   

    }
}
