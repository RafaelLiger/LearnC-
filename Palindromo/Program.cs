namespace Palindromo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro: ");
        string numero = Console.ReadLine();

        char[] digitos = numero.ToCharArray();
        bool palindromo = true;

        for(int i = 0; i < digitos.Length/2; i++)
        {
            if(digitos[i] != digitos[digitos.Length - 1 - i])
            {
                palindromo = false;
                break;
            }
        }
        Console.WriteLine(palindromo);
    }
}
