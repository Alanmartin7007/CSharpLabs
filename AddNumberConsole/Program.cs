using AddNumberLibrary;

namespace AddNumberConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number");
            string input1 = Console.ReadLine();
            //int num1= int.Parse(input1);

            if (!int.TryParse(input1, out int num1))
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.WriteLine("Enter the Second Number");
            input1 = Console.ReadLine();
            if (!int.TryParse(input1, out int num2))
            {
                Console.WriteLine("Invalid Output");
                return;
            }
            int sum = NumbersClass.Add(num1  ,num2);
            Console.WriteLine("Sum =" + sum);
        }
    }
}