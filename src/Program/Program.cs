using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("José", 75);
            Person p2 = new Person("María", 44);
            Person p3 = new Person("Lucas", 41);
            Person p4 = new Person("Carlos", 18);
            Person p5 = new Person("Felipe", 20);
            Person p6 = new Person("Sara", 15);
            Person p7 = new Person("Josefina", 17);
            Person p8 = new Person("Julia", 15);
            Node n1 = new Node(p1);
            Node n2 = new Node(p2);
            Node n3 = new Node(p3);
            Node n4 = new Node(p4);
            Node n5 = new Node(p5);
            Node n6 = new Node(p6);
            Node n7 = new Node(p7);
            Node n8 = new Node(p8);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);
            n3.AddChildren(n8);


            // visitar el árbol aquí
        }
    }
}
