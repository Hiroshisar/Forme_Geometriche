using Forme_Geometriche;

Quadrato q1 = new Quadrato
{
    Lato = 15.5f
};
FormaGeometrica q2 = new Quadrato
{
    Lato = 158f
};
FormaGeometrica q3= new Quadrato
{
    Lato = 7.8865f
};

Cerchio c1 = new Cerchio
{
    Diametro = 78f
};
FormaGeometrica c2 = new Cerchio
{
    Diametro = 87.66f
};
FormaGeometrica c3 = new Cerchio
{
    Diametro = 1.8f
};

Rettangolo r1 = new Rettangolo
{   
    Base = 5f,
    Altezza = 18.2f
};
FormaGeometrica r2 = new Rettangolo
{   
    Base = 3f,
    Altezza = 5f
};
FormaGeometrica r3 = new Rettangolo
{   
    Base = 17.8f,
    Altezza = 6f
};

TriangoloRettangolo tr1 = new TriangoloRettangolo
{
    Base = 25f,
    Altezza = 5f
};
FormaGeometrica tr2 = new TriangoloRettangolo
{
    Base = 7.5f,
    Altezza = 99f
};
FormaGeometrica tr3 = new TriangoloRettangolo
{
    Base = 43.1f,
    Altezza = 77f
};

FormaGeometrica[] forme =
[
    q1, q2, q3, c1 ,c2, c3, r1, r2, r3, tr1, tr2, tr3
];

foreach (FormaGeometrica forma in forme)
{
    Console.WriteLine();
    Console.WriteLine(forma.Nome);
    Console.WriteLine($"Perimetro: {forma.Perimetro()}" );
    Console.WriteLine($"Area: {forma.Area()}" );
}