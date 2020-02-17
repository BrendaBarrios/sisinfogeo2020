/*
 * AUTOR : Brenda Yasmin Barrios Becerra.
 * OBJETIVO : Multiplicación de dos vectores primer elemento de A por ultimo 
 * elmento de B asi hasta n ....
*/



using System;

namespace _12.vectorMultiplica
{
    class Program
    {
        static void Main(string[] args)
        {
           const int MAX = 10;
           double[]A = new double[MAX];
           double[]B = new double[MAX];
           double[]C = new double[MAX];
           Random aleatorio = new Random();

           //Generando números aleatorios
           for(int i=0;i<MAX;i++){
               A[i] = aleatorio.Next(1,50);
               B[i] = aleatorio.Next(1,50);
           }

            //Haciendo la multiplicación del arreglo
            //primera pocisión por la ultima del arreglo 2.
            int longB=B.Length-1;
            for(int i =0; i <= A.Length-1;i++){
               C[i]=A[i]*B[longB-i];
               
            }
            
            //Imprime en consola y manda lamar a los métodos
            Console.Write("\n");
            Console.Write("Este es primer vector:  \n");
            imprime(A);
            Console.Write("\n");
            Console.Write("Este es el segundo vector : \n");
            imprime(B);
            Console.Write("\n");
            Console.Write("Vector ressultante de la multiplicación : \n");
            imprime(C);
            Console.Write("\n");


        }
        //Imprime arreglo.
        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} ");
            
            }
            Console.WriteLine();
        }   
    }
}
