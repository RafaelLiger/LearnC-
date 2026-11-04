namespace Listas;

class Program
{
    static void Main(string[] args)
    {
        List<string> names = ["<Rafael>", "Ana", "Felipe"];
        foreach(var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");    
        }
        Console.WriteLine();
        names.Add("Maria");
        names.Add("Bill");
        names.Remove("Ana");

        foreach(var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}");
        }
        Console.WriteLine($"My name is {names[0]}.");
        Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
        Console.WriteLine($"The list has {names.Count} people in it");

        // pesquisar se item existe na lista

        var index = names.IndexOf("Felipe");
        if (index == -1)
        {
            Console.WriteLine($"When an item is not found, IndexOf returns {index}");
        }
        else
        {
            Console.WriteLine($"The name {names[index]} is at index {index}");
        }

        index = names.IndexOf("Not Found");
        if (index == -1)
        {
            Console.WriteLine($"When an item is not found, IndexOf returns {index}");
        }
        else
        {
            Console.WriteLine($"The name {names[index]} is at index {index}");
        }
        names.Sort();
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}");
        }

        List<int> fibonaccinumbers = [1,1];
        
        while (fibonaccinumbers.Count < 20)
        {
            var previous = fibonaccinumbers[fibonaccinumbers.Count -1];
            var previous2 = fibonaccinumbers[fibonaccinumbers.Count -2];

            fibonaccinumbers.Add(previous + previous2);

        }

        foreach (var number in fibonaccinumbers)
        {
                Console.WriteLine(number);
                
        }    

    }
}
