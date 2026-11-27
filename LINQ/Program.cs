namespace LINQ;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [0,1,2,3,4,5,6,7,8];

        var nunQuery = from num in numbers
                        where num % 2 == 0
                        select num;

        foreach(int num in nunQuery)
        {
            Console.WriteLine(num);
        }                
    }
        
}
