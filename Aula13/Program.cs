namespace Aula13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro valor!");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite e o segundo valor!");
        int num2 = Convert.ToInt32(Console.ReadLine());
       
        if(num1 > num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
     
        Console.WriteLine($"Maior: {num2}\nMenor: {num1}");
    }
}
