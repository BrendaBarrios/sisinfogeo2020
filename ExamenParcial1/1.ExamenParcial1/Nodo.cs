using System;
using System.Collections.Generic;

namespace _1.ExamenParcial1{
    class Nodo{ 

        private string ip;
        private string tipo;
        private string puerto;
        private int saltos;
        private string so;
        private List <Vulnerabilidad> vulne;

        public Nodo(string ip,string tipo,string puerto,int saltos,string so){
            this.ip=ip;
            this.tipo=tipo;
            this.puerto=puerto;
            this.saltos=saltos;
            this.so=so;
            vulne =new List<Vulnerabilidad>();
        }

        public String Ip{
            get { return ip; }
            set { ip = value; }
        }

       
        public String Tipo{
            get { return tipo; }
            set { tipo = value; }
        }

        public String Puerto{
            get { return puerto; }
            set { puerto = value; }
        }

        public String So{
            get { return so; }
            set { so = value; }
        }

        public int Saltos{
            get { return saltos; }
            set { saltos = value; }
        }

        public void AgregarVulnerabilidad(Vulnerabilidad vul){
            vulne.Add(vul);
        }


        public List<Vulnerabilidad >Vulnerabilidad{
            get {return vulne ;}
        }
        

    }
}