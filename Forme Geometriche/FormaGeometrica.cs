namespace Forme_Geometriche;

public abstract class FormaGeometrica
{
    public virtual string Nome { get; }
    public abstract float Perimetro();
    public abstract float Area();
}