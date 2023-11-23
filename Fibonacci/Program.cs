namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prev = 0;
            int next = 1;
            int sum = 0;
            Console.WriteLine("Enter Limit!");
          
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result))

            {

                Console.WriteLine("Invalid value");

                return;

            }
            for (int i = 0; i < result; i++)
            {
                sum = next + prev;
                Console.WriteLine(sum);
                prev = next;
                next = sum;
            }
        }
    }
}