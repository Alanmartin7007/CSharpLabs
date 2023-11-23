namespace Odd_or_Even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            string[] str= new string[10];
            
            Console.WriteLine("Enter the limit");
            string limit=Console.ReadLine();
            if (!int.TryParse(limit,out int num))
            {
                Console.WriteLine("Invalid");

            }
            Console.WriteLine("Enter  numbers:");


            for (int i = 0; i < num; i++)
            {
                Console.Write($"Number {i + 1}: ");
                str[i] = (Console.ReadLine());
                if (!int.TryParse(str[i],out int number))
                {
                    Console.WriteLine("Invalid ");
                    return;
                }
                numbers[i] = number;

                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"{numbers[i]} is even.");
                }
                else
                {
                    Console.WriteLine($"{numbers[i]} is odd.");
                }
            }

            

           
        }
    }
}