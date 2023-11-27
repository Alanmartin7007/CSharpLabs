namespace MethodParamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 2;//object works at complile time
            obj = "abc";

            /* var val = 10; //var works at compile time
             val = "abc";*/

            dynamic obj2 = 10;
            obj2 = "abc"; // when you use dynamic  at run time the datatype is inferred 

            int number = 20;
            Method1(ref number);
            Console.WriteLine(number);
            int number2;
            Method3(1, 2, 3, 4, 5, 6, 7, 8);// params keyword allo=wsa you to pass value withput iusing an array
             
            Method4(new int[] { 1, 2, 3 });
            
            
        }
        static void Method1(ref int num) 
        {
            num = num + 10;

        }
        static void Method2(out int num2)
        {
            num2 = 10;
        }
        static void  Method3(params int[] number)
        {

        }
        static void Method4( int[] number)
        {

        }
    }
}