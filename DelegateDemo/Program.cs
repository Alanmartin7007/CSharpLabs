namespace DelegateDemo
{
    //first stwp
    public delegate void MathDelegate(int num1,int num2);
    internal class Program
    {

        static void Main(string[] args)
        {
            //Third Step
            MathDelegate mathDel = Add;
            mathDel += Sub;
            mathDel += Mul;
            mathDel += Div;

            
           // MathDelegate mathdel2=new MathDelegate(Add); // alternate method

            //Fourth Step

            mathDel(8, 3);

        }
        //Second step define the method to which delegate points to
        public static void Add(int num1,int num2)
        {
            Console.WriteLine("Sum");
            Console.WriteLine(num1+num2);
        }
        public static void Sub(int num1, int num2)
        {
            Console.WriteLine("Diiference");
            Console.WriteLine(num1 - num2);
        }
        public static void Mul(int num1, int num2)
        {
            Console.WriteLine("Multiplication");
            Console.WriteLine(num1 * num2);
        }
        public static void Div(int num1, int num2)
        {
            Console.WriteLine("Division");
            Console.WriteLine(num1 / num2);
        }
    }
}