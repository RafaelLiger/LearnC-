namespace Exercicio2;

public class PagamentoPix : IPagamento
{
    public string Name => "Pix";

    void IPagamento.Processar(decimal pagamento)
    {
        Console.WriteLine($"Pagamento de R${pagamento:F2} realizado via {Name}!"); 
    }
}