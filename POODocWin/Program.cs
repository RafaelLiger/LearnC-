namespace POODocWin;

class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer("Rafael");
        var c1 = new Customer("Grace");
        var c2 = c1;
        c2.Name = "João";
        Console.WriteLine($"Customer: {customer.Name}");
        Console.WriteLine($"C1: {c1.Name}\nC2: {c2.Name}");
        var container = new Container(20);
        container.vercapa();
        double circumference = MathHelpers.CircleCircumference(5.0);
        Console.WriteLine($"Circumference: {circumference:F2}"); // Circumference: 31.42
        
        //ini
        var options = new ConnectionOptions
        {
            Host = "db.example.com",
            Port = 5432,
            UseSsl = true
        };
        Console.WriteLine($"{options.Host}:{options.Port} (SSL: {options.UseSsl})");
        // db.example.com:5432 (SSL: True)
                
            }
        }

// struct Faz uma copia dos dados já class aponta para o mesmo local da memoria.
public struct Customer
{
    public string Name { get; set; } //getters e setters moderno do C#.  

    public Customer (string name) => Name = name;
}
public class Container (int capacity)
{
    private int _capacity = capacity;

    public void vercapa()
    {
        Console.WriteLine(this._capacity);
        
    }
}
//classe estática =========|
/*A biblioteca de classes .NET inclui muitas classes estáticas, como Math e Console. Uma classe estática é implicitamente selada. Você não pode derivar dele ou instanciá-lo.*/
static class MathHelpers
{
    public static double CircleCircumference(double radius) =>
        2 * Math.PI * radius;
}
// Inicializadores de objetos
/*init: Garante que o valor só pode ser definido no momento da criação. Depois de criado, o objeto torna-se somente leitura.*/
class ConnectionOptions
{
    public string Host { get; init; } = "localhost";
    public int Port { get; init; } = 80;
    public bool UseSsl { get; init; }
}