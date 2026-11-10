namespace MetodosConversoes;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 50, 20, 30 };
        int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 } };

        //Pertence à estrutura (Vetores e Matrizes):
        Console.WriteLine(vetor.Length); //Comprimento
        Console.WriteLine(matriz.Rank);  //Quantidade de dimensões
        int[] copia = (int[])vetor.Clone(); //Clone de um vetor (Conversão)

        //Classe Array
        Array.Sort(vetor); //Ordenar os elementos (altera o original)
        Array.Reverse(vetor); //Inverte a ordem dos elementos (altera o original)
        
        int pos = Array.IndexOf(vetor,10); //retorna a posição do indice do elemento 10 (retorna -1 se não encontrar)

        int[] v = {10,20,30};
        string texto = string.Join(", ",v);
        Console.WriteLine(texto);
    }
}
