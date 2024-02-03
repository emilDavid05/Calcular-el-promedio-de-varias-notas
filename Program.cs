class ejercicio7
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la primera nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la cuarta nota:");
        double nota4 = Convert.ToDouble(Console.ReadLine());

        double promedio = CalcularPromedio(nota1, nota2, nota3, nota4);

        Console.WriteLine("El promedio de las 4 notas es: " + promedio);
    }

    static double CalcularPromedio(double nota1, double nota2, double nota3, double nota4)
    {
        return (nota1 + nota2 + nota3 + nota4) / 4;
    }
}