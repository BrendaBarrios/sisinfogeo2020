using System;
namespace _1.ExamenParcial1{
    class Vulnerabilidad{ 

        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private DateTime fecha;
        

         public Vulnerabilidad(string clave,string vendedor,string descripcion,string tipo,DateTime fecha){
            this.clave=clave;
            this.vendedor=vendedor;
            this.descripcion=descripcion;
            this.tipo=tipo;
            this.fecha=fecha;
            

        }


        public string Clave{
            get { return clave; }
            set { clave = value; }
        }

        public string Vendedor{
            get { return vendedor; }
            set { vendedor= value; }
        }

        public string  Descripcion{
            get { return descripcion; }
            set { descripcion= value; }
        }

        public string  Tipo{
            get { return tipo; }
            set { tipo = value; }
        }

        public DateTime Fecha{
            get { return fecha; }
            set { fecha = value; }
        }

    

        public int calcularAntiguedad(){
            DateTime fechavul=fecha;
            DateTime fechaActual= DateTime.Now;

            TimeSpan antiguedad = fechaActual-fechavul;
            return antiguedad.Days/365;
        }


        public override string ToString(){
            return $" Clave : {clave} Vendedor: {vendedor} Descripción : {descripcion} Tipo : {tipo}  Fecha : {fecha}";

             
        }

    }
}
