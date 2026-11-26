using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Colecoes;

class Program
{
    static void Main(string[] args)
    {
        // List<string> Names = ["Rafael", "Pedro", "João"];

        // foreach(string name in Names)
        // {
        //     Console.WriteLine(name);
        // }

        // List<int> Numbers = [1 , 4, 7, 8, 9, 30, 10, 40, 55, 34, 12, 4, 7];

        // var result = Numbers.Where(number => number > 10);
        // //Formas de copiar coleções
        // int[] numcopia = new int[13];
        // Numbers.CopyTo(numcopia);

        // int[] numcopia2 = Numbers.ToArray();

        // foreach(int number in result)
        // {
        //     Console.WriteLine(number);
        // }

        // Console.WriteLine();
        
        // foreach(int num in numcopia.Where(number => number < 10))
        // {
        //     Console.WriteLine(num);
        // }

        // Console.WriteLine();

        // foreach(int num in numcopia2.Where(number => number % 2 == 0))
        // {
        //     Console.WriteLine(num);
        // }
        // Dictionary<string, string> telephones = new()
        // {
        //     ["RAFAEL"] = "(21)98681-8568",
        //     ["PEDRO"] = "(21)98331-8436",
        //     ["FERNANDA"] = "(21)98338-8356",
        //     ["BIANCA"] = "(21)96261-8456"
            
        // };
        // Console.Write("Name: ");
        // Console.WriteLine(telephones[Console.ReadLine().ToUpper()]);

        //  #### FILA ### o primeiro a entrar e o primeiro a sair

        Queue<string> fila = new();

        fila.Enqueue("Rafael");
        fila.Enqueue("Maria");
        fila.Enqueue("João");

        string atendido = fila.Dequeue();
      
        Console.WriteLine(atendido);
        // string atendido2 = fila.Dequeue();
      
        // Console.WriteLine(atendido2);

        // for(int i = 0; i < 10; i++)
        // {
        //     string atendido = fila.Dequeue();
        //     Console.WriteLine(atendido);
        // }

        // ## PILHA o ultimo a entrar é o primeiro a sair
        // .push adiciona elemento à pilha
        Stack<string> pratos = new();

        pratos.Push("Prato 1");
        pratos.Push("Prato 2");
        pratos.Push("Prato 3");
    
        string prato = pratos.Pop();
        Console.WriteLine(prato);
    }   
}
