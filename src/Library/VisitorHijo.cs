using System;

namespace Library
{
    public class VisitorHijo : Visitor
    {
        public override string Content()
        {
            return PrimerHijo.Nombre;
        }
    
        public Persona PrimerHijo{get; set;}
        public override void Visit(Persona persona)
        {
            if (PrimerHijo==null)
            {
                PrimerHijo=persona;
            }
            else 
            {
                if (persona.Edad>PrimerHijo.Edad)
                {   
                    PrimerHijo=persona;
                }
            }
        }
        public override void VisitNode(Node node)
        {
            foreach (Node Child in node.Children)
            {
                Child.Aceptar(this);
                this.Visit(Child.Persona);
            }
        }
    }
}