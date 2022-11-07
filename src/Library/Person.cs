using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person 
    {
        public Person (string nombre, int edad)
        {
            this.Nombre=nombre;
            this.Edad=edad;
        }
        public string Nombre {get;set;}
        public int Edad {get;set;}
        public List<Node<Person>> Hijos = new List<Node<Person>>();


        public override string ToString()
        {
            return base.ToString()+ ": " + Nombre.ToString()+" " + Edad.ToString();
        }
 
    }
}
