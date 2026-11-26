using Exercicio2;

class Program
{
    private static void MakePayment()
    {
        Console.Write("Enter the value: ");
        decimal amount = decimal.Parse(Console.ReadLine()!);// ! informa que o valor não será nulo

        Console.WriteLine("\nPAYMENT METHODS:\n l>|PIX\n l>|Credit Card\n l>|Bank Slip\n");
        Console.Write("Select your payment method: ");
        string? paymentType = Console.ReadLine()?.Replace(" ", "");
        
        // if(Enum.TryParse<PaymentMethod>(input, true, out PaymentMethod method))
        // {
        //     IPayment payment = method switch
        //     {
        //         PaymentMethod.PIX => new PIX(),
        //         PaymentMethod.CreditCard => new CreditCard(),
        //         PaymentMethod.BankSlip => new BankSlip(),
        //         _ => throw new ArgumentException("Invalid payment method")
        //     };
        //     Console.WriteLine(payment.Process(value)); 
        // }
        // else
        // {
        //     Console.WriteLine("Invalid payment method");
        // }
        IPayment payment;  
        if(paymentType.Equals(PaymentType.PIX.ToString(),StringComparison.OrdinalIgnoreCase))
        {
            payment =  new PIX();
            Console.WriteLine(payment.Process(amount));
        }
        else if(paymentType.Equals(PaymentType.CreditCard.ToString(),StringComparison.OrdinalIgnoreCase))
        {
            payment = new CreditCard();
            Console.WriteLine(payment.Process(amount));
        }
        else if(paymentType.Equals(PaymentType.BankSlip.ToString(), StringComparison.OrdinalIgnoreCase))
        {
            payment = new BankSlip();
            Console.WriteLine(payment.Process(amount));
        }
        else
        {
            Console.WriteLine("Invalid payment type.");
        }

    }
    static void Main(string[] args)
    {
        MakePayment();
    }
}
public enum PaymentType
{
    PIX,
    CreditCard,
    BankSlip
}