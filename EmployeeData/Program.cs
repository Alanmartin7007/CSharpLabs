using System.Text.RegularExpressions;

namespace EmployeeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The ID");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int id) || id<0)
            {
               
                    Console.WriteLine("invalid value");
                
                return;
            }
            Employee emp = new Employee();
            emp.Id = id;
            Console.WriteLine("Enter the Name");
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid as entry is null");
                return;
            }
            emp.Name = input;
            Console.WriteLine("Ente the BirthDate");
            input = Console.ReadLine();
            if (!DateTime.TryParse(input, out DateTime date1))
            {
                Console.WriteLine("invalid entry");
                return;
            }
            emp.Birthdate = date1;
            Console.WriteLine("Enter the Email");

            input = Console.ReadLine();
            if (!Regex.IsMatch(input, "@\"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$\""))
            {
                Console.WriteLine("Invalid Email");
            }
            emp.Email = input;
            
        }
    }
}