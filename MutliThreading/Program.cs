namespace MutliThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread id{Thread.CurrentThread.ManagedThreadId}");

            Thread childThread = new Thread(new ThreadStart(Method1));
            childThread.Start();
            Thread.CurrentThread.un

        }
        static void Method1()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Thread id{Thread.CurrentThread.ManagedThreadId}");
        }
    }
}