namespace Forme_Geometriche;

public class TriangoloRettangolo : Rettangolo
{
    public override string Nome => "Triangolo Rettangolo";

    private float Ipotenusa => float.Hypot(Base, Altezza);

    public override float Perimetro()
    {
        return Base + Altezza + Ipotenusa;
    }

    public override float Area()
    {
        return (Base * Altezza) / 2;
    }
}
