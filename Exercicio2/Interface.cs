namespace Exercicio2;

public interface IPagamento
{
    void Processar(decimal valor);
    
    string Name{ get;}
}