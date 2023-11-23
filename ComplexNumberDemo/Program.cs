namespace ComplexNumberDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumbers c1 = new ComplexNumbers(10, 3);
            ComplexNumbers c2 = new ComplexNumbers(2, 7);
            ComplexNumbers c3 = c1 + c2;
            Console.WriteLine(c3);
        }
    }
}
