namespace Exercicio2;

public class PagamentoBoleto:IPagamento
{
    public string Name => "Boleto";

    void IPagamento.Processar(decimal pagamento)
    {
        Console.WriteLine($"Pagamento de R${pagamento:F2} realizado via {Name}!");
    }    
}