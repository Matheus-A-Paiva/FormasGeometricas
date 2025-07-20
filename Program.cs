using FormasGeometricas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Áreas de Formas Geométricas \n");

        Forma retangulo = new Retangulo(10, 5);
        Forma triangulo = new Triangulo(8, 4);
        Forma circulo = new Circulo(7);

        List<Forma> formas = new List<Forma> { retangulo, triangulo, circulo };

        foreach (Forma forma in formas)
        {
            Console.WriteLine($"Forma: {forma.GetType().Name}");
            Console.WriteLine($"Área: {forma.CalcularArea():F2}");
            Console.WriteLine("------------------------------");
        }

        double areaTotal = formas.Sum(f => f.CalcularArea());
        Console.WriteLine($"\nÁrea total das formas: {areaTotal:F2}");

    }
}
