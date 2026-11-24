using Exercicio2;

class Program
{
    private static void RealizarPagamento(IPagamento pagamento)
    {
        pagamento.Processar(300);
    }
    static void Main(string[] args)
    {
        RealizarPagamento(new PagamentoPix());
        RealizarPagamento(new PagamentoBoleto());
        RealizarPagamento(new PagamentoCartaoCredito());  
    }
}