namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            object obj = i;//boxing
            int j = (int)obj;//unboxing

            int[] array = {1,2, 3};
            object[] array2 = { 1, 2, true, "ALAN" };




        }
    }
}