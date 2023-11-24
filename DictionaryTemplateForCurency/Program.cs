
using System.Diagnostics;

namespace DictionaryforCurencyConversion
{


    internal class Program
    {
        static void Main(string[] args)
        {
           /* Dictionary<string, string> currency = new Dictionary<string, string>
            {
                {"INR","INDIAN RUPEES" },
                {"USD","US DOLLAR" },
                {"SGD","SINGAPORE DOLLAR" },
                {"EUR","EURO" }
            };*/
            Console.WriteLine("Enter the Source Currency");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid");

            }
            string target = Console.ReadLine();
            Console.WriteLine("Enter the Target Currency");
            if (string.IsNullOrEmpty(target))
            {
                Console.WriteLine("Invalid");

            }
            Dictionary<string, KeyValuePair<string, double>> currency1 = new Dictionary<string, KeyValuePair<string,double>>
            {
                {"INR",new KeyValuePair<string, double> ("USD",.17)},
                {"EURO",new KeyValuePair<string, double> ("USD",.1)},
                {"SNG",new KeyValuePair<string, double> ("USD",.14)}
                
            }; 
        }
    }
}