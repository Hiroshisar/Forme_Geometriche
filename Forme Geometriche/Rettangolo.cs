namespace Forme_Geometriche;

public class Rettangolo : FormaGeometrica
{
    public override string Nome => "Rettangolo";

    public float Base { protected get; set; }

    public float Altezza { protected get; set; }

    public override float Perimetro()
    {
        return (Base + Altezza) * 2;
    }

    public override float Area()
    {
        return Base * Altezza;
    }
}