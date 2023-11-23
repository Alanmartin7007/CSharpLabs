namespace IndexedDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA instance1=new ClassA(3);
            instance1[1] = 3;
            foreach (var item in instance1)
            {
                Console.WriteLine(item);
            }
        }
    }
}