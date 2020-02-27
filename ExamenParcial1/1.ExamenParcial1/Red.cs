using System;
using System.Collections.Generic;

namespace _1.ExamenParcial1{
    class Red{ 

        private string empresa;
        private string propietario;
        private string domicilio;
        private List <Nodo> nodos;

        public Red(string empresa,string propietario,string domicilio){
            this.empresa=empresa;
            this.propietario=propietario;
            this.domicilio=domicilio;
            nodos =new List<Nodo>();
        }

        public String Empresa{
            get { return empresa; }
            set { empresa = value; }
        }

       
        public String Propietario{
            get { return propietario; }
            set { propietario = value; }
        }

        public String Domicilio{
            get { return domicilio; }
            set { domicilio = value; }
        }

        public void AgregarNodo(Nodo cte){
           nodos.Add(cte);
        }  

        public List<Nodo>Nodos{
            get {return nodos;}
        } 

        public int mayor(){
           int m=nodos[0].Saltos;
           foreach (Nodo n in nodos){
               if( n.Saltos > m){
                   m=n.Saltos;
               }
            }
            return m;
        }

        public int menor(){
           int m=nodos[0].Saltos;
           foreach (Nodo n in nodos){
               if( n.Saltos < m){
                   m=n.Saltos;
               }
            }
            return m;
        }


    }
}