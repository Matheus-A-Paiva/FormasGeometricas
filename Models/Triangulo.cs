namespace FormasGeometricas;

public class Triangulo : Forma
{

    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double altura, double baseTriangulo)
    {
        Altura = altura;
        Base = baseTriangulo;
    }
    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }
}
