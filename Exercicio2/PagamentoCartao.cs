namespace Exercicio2;

public class PagamentoCartaoCredito:IPagamento
{
    public string Name => "Cartão de Crédito";

    void IPagamento.Processar(decimal pagamento)
    {
        Console.WriteLine($"Pagamento de R${pagamento:F2} realizado via {Name}!");
    }    
}