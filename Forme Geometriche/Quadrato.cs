namespace Forme_Geometriche;

public class Quadrato : FormaGeometrica
{
    public override string Nome => "Quadrato";

    public float Lato { private get; set; }

    public override float Perimetro()
    {
        return Lato * 4;
    }

    public override float Area()
    {
        return Lato * Lato;
    }
}