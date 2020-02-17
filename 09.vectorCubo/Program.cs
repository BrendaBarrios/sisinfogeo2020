/*
 * AUTOR : Brenda Yasmin Barrios Becerra.
 * OBJETIVO : Elevar al cubo los elementos de un vector.
*/

using System;

namespace _09.vectorCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const int MAX=30;
            double[] A = new double[MAX];
            double[] B = new double[MAX];
            

            Random aleatorio=new Random();

            // Generar números aleatorios
            for(int i=0;i<MAX;i++){
                A[i]=aleatorio.Next(1,10);
                B[i]=Math.Pow(A[i],3);
            }

            
            Console.WriteLine("Eleva al cubo 30 elementos en un vector \n");
            imprime(A);
            imprime(B);
           
        }

        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} ");
            
            }
            Console.WriteLine();
        }
    }
}
