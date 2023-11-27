namespace CsharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Method1(10);
            static void Main(string[] args)
            {
                /*var i=10; */
                // Method1(10);
                //var messa
                var product = new
                {
                    id = 1,
                    name = "headphone",
                    price = 4000
                };
                string number = "123";
                int num = number.ToNumber();
                Console.WriteLine(num);
                Customer customer1 = new Customer(1);
                // customer1.CustomerId = 1;
                customer1.Name = "Jon Snow";
                customer1.city = "westeros";
                Customer customer2 = new Customer(2)
                {
                    // CustonmerId = 2,
                    Name = "arya Starc",
                    city = "westeros"
                };
                //collection initializer
                List<Customer> list = new List<Customer>
            {
                customer1,
                customer2,
                //object initializer
                new Customer(3){
                    Name="Tyrion",
            city="westros",

        }
            };
            }
        }
    }
}