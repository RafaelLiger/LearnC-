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
        Console.WriteLine("Qual o tipo de cliente? ");
        string customerInput = Console.ReadLine();

        // "Tratamento" de entradas
        if(decimal.TryParse(amountTxt,out decimal amount))
        {
            return;
        }
        else
        {
            Console.WriteLine($"Entrada { amountTxt} inválida!");   
        }

        //decimal amount = Convert.ToDecimal(amountTxt);
        string customer = customerInput.Trim();

        // associar entrada de tipo de cliente com membro do enum
        // True  = para ignorar maiusculas e minusculas. out = retorna o valor por veio da variavel nova
        if(Enum.TryParse<customerType>(customer, true, out customerType customerOutput))
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
