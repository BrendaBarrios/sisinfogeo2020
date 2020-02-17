using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1
{
    class empleado
    {
        //Miembros de clase
        private string nombre;
        private int edad;
        //Constructor(es)
        public empleado(){

        }

         public empleado(string nombre,int edad){
             this.nombre=nombre;
             this.edad=edad;
        }
        //Son  propiedades de la clase
        public string Nombre{
            get{return nombre;}
            set{nombre=value;}
        }

        public int Edad{
            get{return edad;}
            set{edad=value;}
        }

        //metodos de la clase
        public string Vacaciones(DateTime ini,int dias){
            DateTime fin;
            fin=ini.AddDays(dias);
            return fin.ToString("dd/MM/yy");
        }

        //Sibrecargamos el metodo ToStrong heredado de la clase base(Object)
        public override string ToString(){
            return $"Nombre:{nombre}, Edad:{edad}";
        }


    }
}