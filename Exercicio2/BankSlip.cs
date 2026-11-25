namespace Exercicio2;

public class BankSlip:IPayment
{
    public string Process(decimal amount)
    {    
        amount = amount * 1.01m;
        return $"Process bank slip payment of ${amount}";
    }    
}