namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Collection

            // List Collection 

            List<string> recipe = new List<string>();
            Console.WriteLine(recipe.Capacity);
            recipe.Add("pasta");
            recipe.Add("pizaa");
            recipe.Add("payasam");
            recipe.Add("chick");
            recipe.Add("chick");
            recipe.Add("chick");
            Console.WriteLine(recipe.Capacity);
            recipe.Add("chick");
            recipe.Add("chick");
            recipe.Add("chick");
            Console.WriteLine(recipe.Capacity);
             recipe.Clear();
            Console.WriteLine(recipe.Capacity);
            List<int> number = new List<int>
            {
                1, 2, 3, 4, 5, 6
            };

            

        }
    }
}