using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {         
            Node n1 = new Node(1,"Marta", 73);
            Node n2 = new Node(2,"José", 42);
            Node n3 = new Node(3,"Luis", 33);
            Node n4 = new Node(4,"Martina", 30);
            Node n5 = new Node(5,"Juan Ignacio", 17);
            Node n6 = new Node(6,"José María", 13);
            Node n7 = new Node(7,"Federica", 4);
            Node n8 = new Node(8,"Javier", 9);
            Node n9 = new Node(9,"Daniel", 2);

            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);

            n2.AddChildren(n5);
            n2.AddChildren(n6);

            n3.AddChildren(n7);
            n3.AddChildren(n8);

            n4.AddChildren(n9);

            VisitorEdad EdadTotal1 = new VisitorEdad();
            EdadTotal1.VisitNode(n1);
            Console.WriteLine($"Suma Total de las Edades de la Familia = {EdadTotal1.Content()}");

            VisitorNombre MasLargo1 = new VisitorNombre();
            MasLargo1.VisitNode(n1);
            Console.WriteLine($"{MasLargo1.Content()} es el nombre más largo.");

            VisitorHijo Hijo1 = new VisitorHijo();
            Hijo1.VisitNode(n1);
            Console.WriteLine($"{Hijo1.Content()} es el hijo más grande.");
        }
    }
}