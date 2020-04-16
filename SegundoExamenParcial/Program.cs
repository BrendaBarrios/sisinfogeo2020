using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;


namespace SegundoExamenParcial
{
    class Program
    {
        static void Archivo()
        {
           // Importar archivo cvs en un la clase Empleado
            List<Empleado> registros = new List<Empleado>();
            registros=Leer("datos.cvs");
            Console.WriteLine("\nLeyendo registros  del archivo datos.cvs\n");
           

            // Agregar registros adicionales
            registros.Add(new Empleado {Rfc="CARC771123", Nombre="CARLOS CASTANEDA RODRIGUEZ", Area ="JUBILADOS" , Salario=5456.66});
            registros.Add(new Empleado {Rfc="SOBR711202", Nombre="ROCIO SOTO BOTELLO", Area ="JUBILADOS" , Salario=6423.66});
            registros.Add(new Empleado {Rfc="SUGA791124", Nombre="ARACELI SUSTAITA GOMEZ", Area ="PROMOCION" , Salario=2380});
            registros.Add(new Empleado {Rfc="DEAM690813", Nombre="MARGARITA DELGADILLO ARCE", Area ="PROMOCION" , Salario=1858});
            registros.Add(new Empleado {Rfc="PETT670521", Nombre="PEREZ TORRES MARIA TRINIDAD", Area ="PROMOCION" , Salario=1851});
            registros.Add(new Empleado {Rfc="ROLE771004", Nombre="ERIKA FRANCISCA ROBLES LOPEZ", Area ="JUBILADOS" , Salario=4691.44});
            registros.Add(new Empleado {Rfc="LERK911214", Nombre="KARELY GUADALUPE LEAL RAMOS", Area ="DEPORTE" , Salario=1223.66});
            registros.Add(new Empleado {Rfc="BEAY911116", Nombre="YESICA BERUMEN ACOSTA", Area ="CULTURA" , Salario=6423.66});

            Console.WriteLine("\nCreando archivo nomina.........\n");
            // Grabar todos los registros en un nuevo archivo
            Grabar(registros,"nomina.cvs");

            // Leer nuevamente del archvo con todos los registros
            List<Empleado> registros2 = new List<Empleado>();
            registros2=Leer("nomina.cvs");

     
        }

        // Recibe un nombre de archivo y regresa una lista de registros de la clase Empleado

        public static List<Empleado> Leer(string file) {
         
         
            using (var  reader = new StreamReader(file))
            using (var cvs = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                cvs.Configuration.HasHeaderRecord=false;
                cvs.Read();
                var records=cvs.GetRecords<Empleado>().ToList();
                return records;
            }
        }

         // Recibe una lista de registros de la clase Foo, y un nombre de archivo en el cual graba los datos
        public static void Grabar(List<Empleado> records, string file) {
            using (var writer = new StreamWriter(file))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }           
        } 

        //Ejecuta el programa mandando llamar  a archivo y al menu
        static void Main(){
            Archivo();
            Menu();
        }
        
        //Es el menu de opciones y contienen las tareas correspondientes.
        static void Menu(){
            Console.WriteLine("-----------------Menu------------");
            Console.WriteLine(" Listado de nomina orden original......... [1]");
            Console.WriteLine(" Listado de nomina ordenado por nombre ... [2]");
            Console.WriteLine(" Listado de nomina ordenado por salario .. [3]");
            Console.WriteLine(" Listado de nomina con salario > 3500 .... [4]");
            Console.WriteLine(" Listado de nomina con 77 en el Rfc....... [5]");
            Console.WriteLine(" Listado de nomina con los JUBILADOS...... [6]");
            Console.WriteLine(" Listado de nomina agrupado por area...... [7]");


            Console.WriteLine("Seleccione una opción: ");

            switch (Console.Read()){

            case '1':
                 
                Console.WriteLine("\nListado de nomina orden original\n");
                List<Empleado> registros2 = new List<Empleado>();
                registros2=Leer("nomina.cvs");                    
                registros2.ForEach(r=>Console.WriteLine(r.ToString().Replace(',',' '))); 
                Console.WriteLine($"Total:{registros2.Count()}");
                
            break;
               
            case '2':
                Console.WriteLine("\nListado de nomina orden por nombre\n");
                List<Empleado> registros = new List<Empleado>();
                registros=Leer("nomina.cvs");  
                var q1 =(from est in registros orderby est.Nombre select  est).ToList();
                q1.ForEach(r=>Console.WriteLine(r.ToString().Replace(',',' '))); 
                Console.WriteLine($"Total:{q1.Count()}");
                
            break;

            case '3':
                Console.WriteLine("\nListado de nomina orden por salario:\n");
                List<Empleado> registros3 = new List<Empleado>();
                registros3=Leer("nomina.cvs");  
                var q2 =(from est in registros3 orderby est.Salario descending select  est).ToList();
                q2.ForEach(est=> Console.WriteLine(est));
                Console.WriteLine($"Total:{q2.Count()}");

            break;

            case '4':
                Console.WriteLine("\nListado de nomina con salario > 3500:\n");
                List<Empleado> registros4 = new List<Empleado>();
                registros4=Leer("nomina.cvs");  
                var q4 =(from est in registros4 where est.Salario > 3500 orderby est.Salario descending select est).ToList();
                q4.ForEach(est=> Console.WriteLine(est));
                Console.WriteLine($"Total:{q4.Count()}");
                
            break;
                    
            case '5':
                Console.WriteLine("Listado de nomina con 77 en el Rfc\n");
                List<Empleado> registros5 = new List<Empleado>();
                registros5=Leer("nomina.cvs");  
                var q5 =(from est in registros5 where est.Rfc.Contains("77") orderby est.Salario descending select est).ToList();
                q5.ForEach(est=> Console.WriteLine(est));
                Console.WriteLine($"Total:{q5.Count()}");
       
            break;

            case '6':
                Console.WriteLine("Listado de nomina con los JUBILADOS.\n");
                List<Empleado> registros6 = new List<Empleado>();
                registros6=Leer("nomina.cvs");  
                var q6 =(from est in registros6 where est.Area=="JUBILADOS" select  est).ToList();
                q6.ForEach(est=> Console.WriteLine(est.ToString().Replace(',',' ')));
                Console.WriteLine($"Total:{q6.Count()}");

            break;

            case '7':
                Console.WriteLine("Listado de nomina agrupado por area:\n");
                List<Empleado> registros7 = new List<Empleado>();
                registros7=Leer("nomina.cvs");  
                var q7 =(from est in registros7
                        group est by est.Area 
                        into newGroup
                        orderby newGroup.Key
                        select  newGroup).ToList();
                

                foreach (var nameGroup in q7)
                {
                    Console.Write($"\n\t{nameGroup.Key}:\n");
                    foreach (var est in nameGroup){
                        Console.WriteLine($"\t{est.Rfc}  {est.Nombre}  {est.Area}  {est.Salario}");
                    }
                    Console.WriteLine($"\tTotal:{nameGroup.Count()}");
                }
     
            break;
          
            }
          
        }

    }
}
