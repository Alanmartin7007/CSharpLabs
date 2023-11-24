using System.Collections;

namespace NonGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("abc");
            list.Add(true);
            

            //Stack  LIFO

            Stack items =new Stack();

            items.Push(1);
            items.Push("abc");
            items.Push(true);
            items.Push(false);
            
            
            Console.WriteLine("count is "+items.Count);
           

            //Queue

            Queue Movies = new Queue();
            Movies.Enqueue("Avengers");
            Movies.Enqueue("Interstellar");
            Movies.Enqueue("Tenet");
            Movies.Enqueue("ShutterIsland");
            Movies.Enqueue("Saw");

             var v = Movies.Dequeue();
            Console.WriteLine(v);




        }
    }
}