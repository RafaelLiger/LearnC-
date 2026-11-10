namespace Matrizes;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz =
        {
            {1,2},
            {3,4},
            {5,6}
        };

        for(int i = 0; i < matriz.GetLength(0);i++)
        {
            for(int j = 0;j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i,j]} ");
            }
            Console.WriteLine();
        }
        // iterar de forma linear/ impossilvel alterar valor iterado
        foreach(int n in matriz)
        {
            Console.Write(n);    
        }

        


    }
}
