using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Juan", 45);
            Node<Person> n1 = new Node<Person>(p1);
            Person p2 = new Person("Mario", 50);
            Node<Person> n2 = new Node<Person>(p2);
            Person p3 = new Person("Marta", 43);
            Node<Person> n3 = new Node<Person>(p3);
            Person p4 = new Person("Julieta", 78);
            Node<Person> n4 = new Node<Person>(p4);
            Person p5 = new Person("Manuel", 30);
            Node<Person> n5 = new Node<Person>(p5);
            Person p6 = new Person("Javier", 48);
            Node<Person> n6 = new Node<Person>(p6);
            Person p7 = new Person("Leonardo", 38);
            Node<Person> n7 = new Node<Person>(p7);
            Person p8 = new Person("Ricardo", 40);
            Node<Person> n8 = new Node<Person>(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            n8.AddChildren(n2);
            n8.AddChildren(n1);
            n8.AddChildren(n3);

            // visitar el árbol aquí
        }
    }
}
