
namespace Aula12;

class Program
{
    static void Main(string[] args)
    {
        // classes math

        // constantes
        Console.WriteLine(Math.PI);
        Console.WriteLine(Math.E);

        // valor absoluto/ módulo
        Console.WriteLine(Math.Abs(-10));

        //Maximo e Minimo
        Console.WriteLine(Math.Max(10,20));
        Console.WriteLine(Math.Min(10,20));

        //Potências e raizes
        Console.WriteLine(Math.Pow(2,3)); //8
        Console.WriteLine(Math.Sqrt(16));

        // Arredondamento
        Console.WriteLine(Math.Round(3.6)); //4
        Console.WriteLine(Math.Ceiling(3.6));//4
        Console.WriteLine(Math.Floor(3.6));//3

        // Trigonometria (Radianos)
        double angulo = 45 * (Math.PI /180);
        Console.WriteLine(Math.Sin(angulo));
        Console.WriteLine(Math.Cos(angulo));
        Console.WriteLine(Math.Tan(angulo));

        // LOgaritimos e Exponencias
        Console.WriteLine(Math.Log(10));
        Console.WriteLine(Math.Log10(100));
        Console.WriteLine(Math.Exp(1));
    }
}
