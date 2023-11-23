internal class Program
{
    private static void Main(string[] args)
    {
        //1
        string name = "Param";
        Console.WriteLine("Welcome "+name);

        //2
        Console.WriteLine(string.Format("Welcome {0}",name));
        Console.WriteLine("Welcome {0}", name);

        //3
        Console.WriteLine($"Welcome {name}");

    }
}