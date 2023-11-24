using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable users= new Hashtable();
            string input;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the userId");
                input = Console.ReadLine();
                if (!int.TryParse(input,out int userId))
                {
                    Console.WriteLine("Invalid entry");
                    i--;
                    continue;
                }
                Console.WriteLine("Enter the Name");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Invalid Scenario");
                    i--;
                    continue;
                }
                //users.Add(input, userId);
                users[userId] = input;

            }
            
            foreach(DictionaryEntry element in users)
            {
                Console.WriteLine($"{ element.Key} \t {element.Value}");
            }
            Console.WriteLine("Enter the userId");
            input = Console.ReadLine();
            if (!int.TryParse(input,out int userid))
            {
                Console.WriteLine("Invalid ID");
                return;
            }
            if(users.ContainsKey(userid))
            {
                Console.WriteLine($"User found name is {users[userid]}");
            }
            else
            {
                Console.WriteLine("User Not Found");
            }


        }
    }
}