namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!");
            Console.WriteLine("Available operations: Add, Subtract, Multiply, Divide");

            while (true)
            {
                Console.Write("Enter the operation (add/sub/mul/div): ");
                string operation = Console.ReadLine();

                if (operation != null && (operation == "add" || operation == "sub" || operation == "mul" || operation == "div"))
                {
                    Console.Write("Enter the first number: ");
                    if (!double.TryParse(Console.ReadLine(), out double x))
                    {
                        Console.WriteLine("Invalid input for the number.");
                        continue;
                    }

                    Console.Write("Enter the second number: ");
                    if (!double.TryParse(Console.ReadLine(), out double y))
                    {
                        Console.WriteLine("Invalid input for the number.");
                        continue;
                    }

                    double result = 0;

                    switch (operation)
                    {
                        case "add":
                            result = CalculatorLibrary.Calculator.Add(x, y);
                            break;
                        case "sub":
                            result = CalculatorLibrary.Calculator.Sub(x, y);
                            break;
                        case "mul":
                            result = CalculatorLibrary.Calculator.Mul(x, y);
                            break;
                        case "div":
                            if (y == 0)
                            {
                                Console.WriteLine("Cannot divide by zero.");
                                continue;
                            }
                            result = CalculatorLibrary.Calculator.Div(x, y);
                            break;
                    }

                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please enter a valid operation.");
                }

                Console.WriteLine("Do you want to perform another calculation? (yes/no)");
                string continueOption = Console.ReadLine();
                if (continueOption != "yes")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the Calculator App!");
        }
    }
}