namespace EnumDemo
{
    internal class Enum
    {
        static void Main(string[] args)
        {

            // int[] number = new int[9]; // aloocation
            int[] numbers = { 1, 2, 3, 4, }; //intialization

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(numbers[index]);
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Weekdays day = Weekdays.Wednesday;
            switch (day)

            {
                case Weekdays.Sunday:
                    break;
                case Weekdays.Monday:
                    break;
                case Weekdays.Tuesday:
                    break;
                case Weekdays.Wednesday:
                    break;
                case Weekdays.Thursday:
                    break;
                case Weekdays.Friday:
                    break;
                case Weekdays.Saturday:
                    break;
                default:
                    break;
            }
        }
    }
}