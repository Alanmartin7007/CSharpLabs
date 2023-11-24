namespace DictionaryforCurencyConversion
{
    internal class Program
    {
        static Dictionary<string,Dictionary<string,Double>> exchangeRates=new Dictionary<string,Dictionary<string,Double>>();
        static void Main(string[] args)

        {
            Dictionary<string, double> exchangeRates = new Dictionary<string, double>
        {
            {"USD", 1.0},
            {"EUR", 0.85},
            {"GBP", 0.75},
            {"INR", 0.9 }
            // Add more currencies and their exchange rates as needed
        };

            // Get user input: amount and source currency
            Console.Write("Enter the amount: ");
            if (double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.Write("Enter the source currency (e.g., USD): ");
                string sourceCurrency = Console.ReadLine().ToUpper();
                if (!exchangeRates.ContainsKey(sourceCurrency))
                {
                    Console.WriteLine("Invalid  Entry");
                }


                // Get user input: target currency
                Console.Write("Enter the target currency (e.g., EUR): ");
                string targetCurrency = Console.ReadLine().ToUpper();
                if (!exchangeRates.ContainsKey(targetCurrency))
                {
                    Console.WriteLine("Invalid  Entry");
                }

                // Call the conversion function
                double convertedAmount = ConvertCurrency(amount, sourceCurrency, targetCurrency, exchangeRates);

                // Display the result
                Console.WriteLine($"{amount} {sourceCurrency} is equal to {convertedAmount} {targetCurrency}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric amount.");
            }
        }

        static double ConvertCurrency(double amount, string sourceCurrency, string targetCurrency, Dictionary<string, double> exchangeRates)
        {
            // Check if the source and target currencies exist in the dictionary
            if (exchangeRates.ContainsKey(sourceCurrency) && exchangeRates.ContainsKey(targetCurrency))
            {
                // Convert to USD first
                double usdAmount = amount / exchangeRates[sourceCurrency];

                // Convert to the target currency
                double convertedAmount = usdAmount * exchangeRates[targetCurrency];

                return convertedAmount;
            }
            else
            {
                Console.WriteLine("Invalid currency codes. Please check the currency codes and try again.");
                return 0;
            }
        }
    }
    /* Dictionary<string, string> currency = new Dictionary<string, string>
     {
         {"INR","INDIAN RUPEES" },
         {"USD","US DOLLAR" },
         {"SGD","SINGAPORE DOLLAR" },
         {"EUR","EURO" }
     };*//*
    Console.WriteLine("Enter the amount");
    string input=Console.ReadLine();
    if (!double.TryParse(input,out double amount))
    {
        Console.WriteLine("Invalid");

    }
    Console.WriteLine("Enter the Source Currency");
     input = Console.ReadLine();
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
    *//*Dictionary<string, KeyValuePair<string, double>> currency1 = new Dictionary<string, KeyValuePair<string,double>>
    {
        {"INR",new KeyValuePair<string, double> ("USD",.17)},
        {"EURO",new KeyValuePair<string, double> ("USD",.1)},
        {"SNG",new KeyValuePair<string, double> ("USD",.14)}

    }; */

    /* Tuple<string, string, double> currency = new Tuple<string, string, double>();
     currency.*//*
    Dictionary<string, Dictionary<string, double>> currency = new Dictionary<string, Dictionary<string, double>>
    {
        {"USD", new Dictionary<string, double> {{"INR", 75.0}, {"EUR", 0.85}, {"SGD", 1.36}}},
        {"INR", new Dictionary<string, double> {{"USD", 0.013}, {"EUR", 0.011}, {"SGD", 0.018}}},
        {"EUR", new Dictionary<string, double> {{"USD", 1.18}, {"INR", 88.75}, {"SGD", 1.60}}},
        {"SGD", new Dictionary<string, double> {{"USD", 0.74}, {"INR", 54.51}, {"EUR", 0.63}}}

    };
*/

}