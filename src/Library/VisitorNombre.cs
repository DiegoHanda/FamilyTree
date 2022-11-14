using System;

namespace Library
{
    public class VisitorNombre : Visitor
    {
    
    public string MasLargo {get; set;}
    public VisitorNombre()
    {
        this.MasLargo="";
    }
    public override string Content()
    {
        return MasLargo.ToString();
    }
    
    public override void Visit(Persona persona)
    {
        if (persona.Nombre.Length>MasLargo.Length)
        {
            MasLargo= persona.Nombre;
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