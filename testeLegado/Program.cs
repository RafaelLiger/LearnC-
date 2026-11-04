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
        for(int counter= 0; counter < 11; counter++)
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
        }
        void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }
        }    
    }
}
