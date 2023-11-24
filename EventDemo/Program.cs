namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            //Subscribe to Event
            order.Oncreated += Email.Send;
            order.Oncreated += SMS.Sent;
            order.Create("alanmartin@gmail.com",909090909);
        }
    }
}