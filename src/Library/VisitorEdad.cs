using System;

namespace Library
{
    public class VisitorEdad : Visitor
    {
        public int EdadTotal{get; set;}  
        public int MayorEdad{get; set;}
        public VisitorEdad()
        {
            this.EdadTotal= 0;
        }
        public override string Content()
        {
          return EdadTotal.ToString();
        }
    
        public override void Visit(Persona persona)
        {
            EdadTotal+=persona.Edad;
        }
        public override void VisitNode(Node node)
        {   Visit(node.Persona);
            foreach (Node Child in node.Children)
            {
                Child.Aceptar(this);
            }
        }
    }
}