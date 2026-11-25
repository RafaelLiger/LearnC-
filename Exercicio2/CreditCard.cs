namespace Exercicio2;

public class CreditCard:IPayment
{
    public string Process(decimal amount)
    {   
        amount = amount * 1.02m;
        return $"Process Credit Card payment of ${amount}";
    }    
}