using Exercicio2;

class Program
{
    private static void MakePayment()
    {
        Console.Write("Enter the value: ");
        decimal value = decimal.Parse(Console.ReadLine()!);// ! informa que o valor não será nulo

        Console.WriteLine("\nPAYMENT METHODS:\n l>|PIX\n l>|Credit Card\n l>|Bank Slip\n");
        Console.Write("Select your payment method: ");
        string? input = Console.ReadLine()?.Replace(" ", "");
        
        if(Enum.TryParse<PaymentMethod>(input, true, out PaymentMethod method))
        {
            IPayment payment = method switch
            {
                PaymentMethod.PIX => new PIX(),
                PaymentMethod.CreditCard => new CreditCard(),
                PaymentMethod.BankSlip => new BankSlip(),
                _ => throw new ArgumentException("Invalid payment method")
            };
            Console.WriteLine(payment.Process(value)); 
        }
        else
        {
            Console.WriteLine("Invalid payment method");
        }  
    }
    static void Main(string[] args)
    {
        MakePayment();
    }
}
public enum PaymentMethod
{
    PIX,
    CreditCard,
    BankSlip
}