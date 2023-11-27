using System.Collections.Concurrent;

namespace OptionalandNamedParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(   AddBook(isbn: "abc", price: 1000, title: "alals",author:"xyx");//Named Parameter
        }
        static bool AddBook(string title,string isbn,string author,decimal price =100)
        {
            return true;        }
    }
}