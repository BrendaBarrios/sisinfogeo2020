using System;

namespace _20.ListasV2
{
    class Piezas
    {
        public Piezas(int id,string nombre) => (Id,Nombre) =(id,nombre);
        public int Id{get;set;}
        public string Nombre{get;set;}

        public override string ToString() => $"{Id} - {Nombre}";
    }

}