
namespace testeLegado;

class Program
{
    static void Main(string[] args)
    {

        //ExploreIf();
        // While and Do while
        //int counter = 0;
        // do
        // {
        //     Console.WriteLine($"Hello World! The counter is {counter}");
        //     counter++;
        // } while (counter < 10);

        // void ExploreIf()
        // {
        //     int a = 5;
        //     int b = 3;
        //     if (a + b > 10)
        //     {
        //         Console.WriteLine("The answer is greater than 10.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("The answer is not greater than 10");
        //     }
        // }
        //ExplorerLoops();
        void ExplorerLoops(){
            for(int counter = 10; counter > -1; counter--)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
            }
            
            for(char Column = 'a'; Column < 'k'; Column++)
            {
                for(int row = 1; row < 11; row++)
                {
                    Console.WriteLine($"The cell is ({row}, {Column})");
                }
            }
            
        }
        DivisibleByThree();

        void DivisibleByThree()
        {
            int sum = 0;
            Console.Write($"Divesible by three: ");
            for( int divisible = 1; divisible < 21; divisible++)
            {
                if(divisible % 3 == 0)
                {
                    Console.Write($"{divisible}, ");
                    sum += divisible;
                }
            }
            Console.WriteLine("End.");
            Console.WriteLine($"The sum is {sum}");
        }

    }
}
