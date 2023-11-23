namespace ComplexNumber
{
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber Add(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber(num1.Real + num2.Real, num1.Imaginary + num2.Imaginary);
        }

        public static ComplexNumber Multiply(ComplexNumber num1, ComplexNumber num2)
        {
            double realPart = (num1.Real * num2.Real) - (num1.Imaginary * num2.Imaginary);
            double imaginaryPart = (num1.Real * num2.Imaginary) + (num1.Imaginary * num2.Real);
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public void Display()
        {
            if (Imaginary >= 0)
            {
                Console.WriteLine($"{Real} + {Imaginary}i");
            }
            else
            {
                Console.WriteLine($"{Real} - {Math.Abs(Imaginary)}i");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the complex no 1 Real Part");
            string input = Console.ReadLine();
            if (!int.TryParse(input,out int num1))
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Enter the complex no 1 Imaginary Part");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int num2))
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Enter the complex no 2 Real Part");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int num3))
            {
                Console.WriteLine("Invalid");
            }
            Console.WriteLine("Enter the complex no 2 Imaginary Part");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int num4))
            {
                Console.WriteLine("Invalid");
            }

            ComplexNumber complex1 = new ComplexNumber(num1, num2);
            ComplexNumber complex2 = new ComplexNumber(num3, num4);

           
            Console.WriteLine("Complex Number 1:");
            complex1.Display();

            Console.WriteLine("\nComplex Number 2:");
            complex2.Display();

            
            Console.WriteLine("\nAddition:");
            ComplexNumber sum = ComplexNumber.Add(complex1, complex2);
            sum.Display();

           
        }
    }
}