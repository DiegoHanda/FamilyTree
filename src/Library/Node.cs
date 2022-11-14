using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;
        public Persona Persona {get;}
        private List<Node> children = new List<Node>();

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number, string nombre, int edad)
        {
            this.number = number;
            this.Persona = new Persona (nombre, edad);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Aceptar (Visitor visitor){
            visitor.VisitNode(this);
        }
    }
}