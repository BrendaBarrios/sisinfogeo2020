using System;
using System.Collections.Generic;

namespace TercerExamen
{
    class Program{
        static void Main(string[] args){
            Menu();
            string menu = Console.ReadLine();
            switch (menu){
                case "1":
                    Universidad universidad1  = new Universidad();
                    universidad1.id= 1;
                    universidad1.nombre="UAZ";
                    universidad1.tipo="Publica";
                    universidad1.carreras="Todas";
                    Console.WriteLine(universidad1.ToString());
                    break;
                case "2":
                   string ProfesorMateria = Calificaciones(Materias.Matematicas);
                   Console.WriteLine(ProfesorMateria);
                   break;
                case "3":
                    string FuncionXOR = XOR("uno","uno");
                    Console.WriteLine(FuncionXOR);
                    break;
                case "4":
                    CalifDosParciales CalP = new CalifDosParciales(6,10);
                    Console.WriteLine(GetQuadrant(CalP));
                    break;
                case "5":
                    IEnumerable<string> lista = new string[] {"E","X","A","M","E","N"};
                    UsoUsing(lista);
                    break;
                case "6":
                    Console.WriteLine(FuncionesEstaticasPagos());
                    Console.WriteLine(FuncionesEstaticasSueldo());
                    break;
                case "7":
                    var palabras = new string[]{
                        "Brenda",
                        "Yasmin",
                        "Barrios",
                        "Becerra",
                    };
                    Console.WriteLine($"La cuarta PALABRA {palabras[^4]}");
                    Console.WriteLine($"La ultima PALABRA {palabras[^1]}");
                    
                    break;
                case "8":
                    List<int> alumnos = null;
                    int? grupoA = null; 
                    int? grupoB = null;
                    alumnos ??= new List<int>(); 
                    alumnos.Add(grupoA ??= 26);
                    alumnos.Add(grupoB ??= 26);
                    Console.WriteLine(string.Join(" ", alumnos)); 
                    Console.WriteLine(grupoA);
                    Console.WriteLine(grupoB);
                    break;
                default:
                    Console.WriteLine("No se selecciono opcion");
                    break;
            }
        }

        static void Menu(){
            Console.WriteLine("Caracteristicas nuevas en C#8");
            Console.WriteLine("[1] Miembros de solo lectura.........");
            Console.WriteLine("[2] Expresiones switch................");
            Console.WriteLine("[3] Patrones de tupla.................");
            Console.WriteLine("[4] Patrones posicionales.............");
            Console.WriteLine("[5] Declaraciones Using...............");
            Console.WriteLine("[6] Funciones locales estáticas........");
            Console.WriteLine("[7] Indices y rangos..................");
            Console.WriteLine("[8] Asignación de null.................");
        }

        public struct Universidad{
            public int id {get; set;}
            public string nombre {get; set;}
            public string tipo {get; set;}
            public string carreras {get; set;}

            public readonly override string ToString(){
                return $"La universidad es la {id} y su Nombre es: {nombre}, es {tipo} y con las carreras {carreras}";
            }
        }

        public enum Materias{
            Matematicas,Español,Programacion,Tesis,BaseDatos,Deploy,Sistemas
        }

        public static string Calificaciones(Materias profesores) => profesores switch
        {
            Materias.Matematicas => "Alejandra Garcia Garcia",
            Materias.Español => "Sodel Vazquez Reyes",
            Materias.Programacion => "Carlos Castañeda",
            Materias.Tesis => "Aldonso Becerra",
            Materias.BaseDatos => "Juan Perez Perez",
            Materias.Deploy => "Alejandro Garcia Mauricio",
            _ => "No se encuentra la opcioón",
        };


        public static string XOR(string caracter1 , string caracter2) =>
            (caracter1, caracter2) switch{
                ("cero", "cero") => "Cero",
                ("uno", "uno") => "Cero",
                ("cero", "uno") => "Uno",
                ("uno", "cero") => "Uno",
                _ => "Incorrecto",
            };
        

        public class CalifDosParciales{
            public int A { get; }
            public int B { get; }

            public CalifDosParciales(int a, int b) => (A, B) = (a, b);

            public void Deconstruct(out int a, out int b) =>
                (a, b) = (A, B);
        }

        public enum Quadrant{
            Ninguno,Aprobaste,Registrado,Reprobaste,NoEntraste,NoExistes
        }

        static Quadrant GetQuadrant(CalifDosParciales cal) => cal switch{
            (0, 0) => Quadrant.Registrado,
            var (x, y) when x > 5 && y > 9 => Quadrant.Aprobaste,
            var (x, y) when x < 0 && y < 0 => Quadrant.NoEntraste,
            var (x, y) when x > 0 && y < 6 => Quadrant.Reprobaste,
            _ => Quadrant.NoExistes
        };


        static int UsoUsing(IEnumerable<string> lineas){
            using var archivo = new System.IO.StreamWriter("archivo.txt");
            int skippedLines = 0;
            foreach (string line in lineas){
                if (!line.Contains("Brenda")){
                    archivo.WriteLine(line);
                }else{
                    skippedLines++;
                }
            }
            return skippedLines;
            
        }


        public static int FuncionesEstaticasSueldo(){
            int sueldoDia;
            LocalFuntion();
            return sueldoDia;
            void LocalFuntion() => sueldoDia = 120*7;
        }

        public static int FuncionesEstaticasPagos(){
            int reciboAgua = 200;
            int reciboLuz = 100 ;
            return Add(reciboAgua,reciboLuz);
            //Add si puede ser static por que no accede directamente a la variable
            static int Add(int pagoComida, int pagoRopa) => pagoComida + pagoRopa;
        }

    
    
    }
}