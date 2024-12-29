namespace Forme_Geometriche;

public class Cerchio : FormaGeometrica
{
    public override string Nome => "Cerchio";

    public float Diametro { private get; set; }

    private float Raggio => Diametro / 2;

    private float Pi => (float)Math.PI;

    public override float Perimetro()
    {
        return Diametro * Pi;
    }

    public override float Area()
    {
        return Pi * (float)Math.Pow(Raggio, 2);
    }
}