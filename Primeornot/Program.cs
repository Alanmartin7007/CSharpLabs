namespace Primeornot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean isPrime= true;

            Console.WriteLine("Enter a number!");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int result))

            {

                Console.WriteLine("Invalid value");

                return;

            }
            if (result == 1)
            {
                Console.WriteLine(" Not a Prime number");
            }
            for (int i = 2; i <= Math.Sqrt( result); i++)
            {
                if (result % i == 0)
                {
                    isPrime = false;

                    
                }
            }
            if (isPrime)
                Console.Write("Number is Prime.");
            else
            {
                Console.WriteLine("NOT PRIME");
            }
        }

    }
}
