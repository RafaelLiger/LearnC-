namespace DiscountCalculator;

enum customerType
{
    Comum,
    Premium,
    VIP
}
class Program
{
    static void Main(string[] args)
    {    
        // Entradas
        Console.WriteLine("Qual o valor total da compra? ");
        string amountTxt = Console.ReadLine();
        Console.Write("Qual o tipo de cliente?\n[Comum] [Premium] [VIP]: ");
        string customerInput = Console.ReadLine();
        
        // "Tratamento" de entradas
        if(!decimal.TryParse(amountTxt,out decimal amount)) // Se terminar false da um return e termina a execução
        {
            return;
        }

         //decimal amount = Convert.ToDecimal(amountTxt);
        string customer = customerInput.Trim();

        // associar entrada de tipo de cliente com membro do enum
        if(Enum.TryParse<customerType>(customer, true, out customerType customerOutput)) // True  = para ignorar maiusculas e minusculas. out = retorna o valor por veio da variavel nova
        {
            Console.WriteLine($"Cliente selecionado: {customerOutput}");

            decimal discount = customerOutput switch
            {
                customerType.Comum => 0.00m,
                customerType.Premium => 0.10m,
                customerType.VIP => 0.20m,
                _=>0.00m
            };

            decimal discountCalc = amount - amount * discount;

            Console.WriteLine($"Valor: R${amount}");
            Console.WriteLine($"Valor final para cliente {customerOutput}: R${discountCalc}");
        }
        else
        {
            Console.WriteLine("Tipo de cliente inválido!");
        }
    }
}