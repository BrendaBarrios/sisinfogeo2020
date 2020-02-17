/*
 * AUTOR : Brenda Yasmin Barrios Becerra.
 * OBJETIVO : Imprimir cuantos son ceros, cuantos son negativos, cuantos positivos,
 * Imprimir además la suma de los negativos y la suma de los positivos.
*/


using System;

namespace _10.vectorSuma
{
    class Program
    {
         static void Main(string[] args)
        {
            
            const int MAX=30;
            double[] A = new double[MAX];
            Random aleatorio=new Random();
            int cp=0,cn=0,cz=0;
             double sp=0,sn=0,sz=0;

            // Generar números aleatorios
            for(int i=0;i<MAX;i++){
                A[i]=aleatorio.Next(-10,50);
                if(A[i]>0){
                    cp++;
                    sp+=A[i];
                }else if (A[i]<0){
                    cn++;
                    sn+=A[i];
                }else{
                    cz++;
                    sz+=A[i];
                }
                
            }

            Console.WriteLine("Suma de números con vector aleatorio \n");
            imprime(A);
            Console.WriteLine($"Los positivos son: {cp} y suman {sp}");
            Console.WriteLine($"Los negativos son: {cn} y suman {sn}");
            Console.WriteLine($"Los negativos son: {cz} y suman {sz}");

        }

        static void imprime(double[] v){
            for(int i=0;i<v.Length;i++){
                Console.Write($"{v[i]} ");
            
            }
            Console.WriteLine();
        }
    }
}
