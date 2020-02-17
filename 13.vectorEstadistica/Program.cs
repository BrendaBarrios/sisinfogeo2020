/*
 * AUTOR : Brenda Yasmin Barrios Becerra.
 * OBJETIVO : Calcula el elemento mayor,menor,la media de 
 *los numeros,la varianza y la desviación estandar.
 -
*/



using System;

namespace _13.vectorEstadistica
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // Pediendo datos.
            Console.WriteLine("¿Cuantos elementos deseas ingresar?");
            int cantidad=Int32.Parse(Console.ReadLine());
            
            double[]A = new double[cantidad];

            //Guardando la cantidad de datos
            

            for(int i=0;i<cantidad;i++){
                Console.WriteLine("Ingresa el elemento : ");
                int elemento=Int32.Parse(Console.ReadLine());
                A[i]=elemento;
             
            
            }
            
            //Se ejecutan y se muestran los resultados.
            
            Console.Write("El vector que ingresaste es : ");
            imprime(A);
            Console.Write("El número mayor es : ");
            Console.WriteLine(numayor(A));
            Console.Write("El número menor es : ");
            Console.WriteLine(numenor(A));
            Console.Write("El promedio es : ");
            Console.WriteLine(promedio(A));
            Console.Write("La varianza  es : ");
            Console.WriteLine(varianza(A));
            Console.Write("La desviación estandar es : ");
            Console.Write(desEstandar(A));
            
            Console.Write("\n");

        }

        //Calculando numero mayor.
        static  double numayor(double[] A){
            double mayor=A[0];
            for(int i=0;i<A.Length;i++){
                if(A[i]>mayor){
                    mayor=A[i];
                }
            }
            return mayor;
        } 


        //Calculando numero mayor.
        static  double numenor(double[] A){
            double menor=A[0];
            for(int i=0;i<A.Length;i++){
                if(A[i]<menor){
                    menor=A[i];
                }
            }
            return menor;
        } 

        //Calculando promedio.
        static double promedio(double[] A){
             double promedio=0.0;
            for(int i=0;i<A.Length;i++){ 
                promedio+=A[i]/A.Length;
            }
            return promedio;
            
        } 

        //Calculando varianza.
        static double varianza(double[] A){
            double varianza=0.0;
            double longitud=A.Length;
           
            for(int i=0;i<A.Length;i++){
                varianza+=(Math.Pow(A[i]-(promedio(A)),2.0))/longitud;
                
            }
            return varianza;
        } 

        //Calculando promedio.
        static double desEstandar(double[] A){
             double desEst=0.0;
            for(int i=0;i<A.Length;i++){ 
                desEst=Math.Sqrt(varianza(A));
            }
            return desEst;
            
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
