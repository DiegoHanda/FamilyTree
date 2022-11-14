using System;

namespace Library
{
    public abstract class Visitor
    {
        public abstract string Content();
        public abstract void Visit (Persona persona);
        public abstract void VisitNode (Node node);
    }
}