namespace Lanbda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,3,4,5,6};
            List<int> even = list.FindAll(x=>(x%2)==0);
            foreach(var x in even) {
                Console.WriteLine("{0}",x);
            }
            Console.WriteLine();

            list.RemoveAll(x=>x>3);
            foreach (var x in list)
            {
                Console.WriteLine("{0}", x);
            }
        }
    }
}