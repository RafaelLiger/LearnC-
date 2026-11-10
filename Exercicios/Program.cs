using System.Collections.Specialized;

namespace Exercicios;

class Program
{
    static void Main(string[] args)
    {
        //Exercício 01 ====================|

        // Console.WriteLine("Quantos graus celsius deseja converter? ");
        // double temp = Convert.ToDouble(Console.ReadLine());

        // temp = (temp * 9/5) + 32;

        // Console.WriteLine($"{temp:F2} F");

        // Vetores e Matrizes ==============|
        // exercicio 1:
        //ex1();
        void ex1()
        {
            int[] vetor = [2,4,5,6,7];
            double soma = 0;
            int contador = 0;

            foreach(int i in vetor)
            {
                soma += i;    
            }

            foreach(int j in vetor)
            {
                if(j > soma / vetor.Length)
                {
                    contador++;
                }
            }
            
            Console.WriteLine($"Existem {contador} valores maiores que a media");
        }    

        //Exercício 2
        //reverter();
        void reverter()
        {
            // Aqui new cria um novo vetor, sem ele oq seria copiado seria a referência.
            int[] vetor1 = [1,2,3,4,5,6];
            int[] vetor2 = new int[vetor1.Length];// Ou vetor1.ToArray(); 
            
            for(int i=0; i < vetor1.Length;i++)
            {
                vetor2[i] = vetor1[vetor1.Length-1-i];
            }
            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.Write(vetor2[i]+" ");
            }
        }
        maior();
        void maior()
        {
            int[] vetor = [100,2,33,4,5];
            int posicaoMaior = 0;
            int temp = 0;
            for(int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] > temp)
                {
                    temp = vetor[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine($"Posição do maior: {posicaoMaior}");
        }  
    }
}
