namespace Exercicio2;

public class PIX: IPayment
{
    public string Process(decimal amount)
    {
        amount = amount * 0.95m;
        return $"Process PIX payment of ${amount}"; 
    }
}