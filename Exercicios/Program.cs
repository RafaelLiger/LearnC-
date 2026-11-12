using System.Collections.Specialized;
using System.Globalization;

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
        // Exercío 3
        //maior();
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
        //Exercício 4
        //par();
        void par()
        {
            int[] vetor = [1,2,3,4,5,6,7,8,9,10,11,12];
            int soma= 0;

            foreach(int n in vetor)
            {
                if(n%2 == 0)
                {
                    soma+=n;
                }
            }
            Console.WriteLine($"Soma de números pares: {soma}");
        }
        // Exercício 5
        //diagonal();
        void diagonal()
        {
            int[,] matriz =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            int soma =0;
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                soma += matriz[i,i];    
            }
            Console.WriteLine($"Soma da diagonal: {soma}"); 
        }
        //Exercício 6
        //negativos();
        void negativos()
        {
            int[,] matriz =
            {
                {1,2},
                {3,-4},
                {-5,6},
                {7,-8},
                {9,10}
            };
            int contador = 0;
            foreach(int n in matriz)
            {
                if(n < 0)
                {
                    contador++;
                }
            }
            Console.WriteLine($"Existem {contador} números negativos.");
        }
        //Exercício 7
        //maiorVMatriz();
        void maiorVMatriz()
        {
            int[,] matriz =
            {
                {1,3},
                {7,0},
                {8,4},
                {4,9},
                {5,6}
            };

            for(int i = 0;i < matriz.GetLength(0); i++)
            {
                int maior = matriz[i,0];
                for(int j = 0;j < matriz.GetLength(1); j++)
                {
                    if(matriz[i,j] > maior)
                    {
                        maior = matriz[i,j];
                    }   
                }
                Console.WriteLine($"Maior da linha {i}: {maior}");  
            }
            
        }
        //Exercicio 8
        valorIgual();
        void valorIgual()
        {
            int[] vetor = [1,3,4,5,3,6,8];
            for(int i= 0; i < vetor.Length; i++)
            {
                for(int j=-1; j < 0; j--)
                {
                    if(vetor[i] == vetor[j])
                    {
                        Console.WriteLine($"O número {vetor[i]} se repete.");
                    }
                } 
            }
        }
    }
}
