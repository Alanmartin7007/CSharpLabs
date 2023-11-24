using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Email
    {
        public static void Send(object sender, OrderEventsArgs e)
        {
            Console.WriteLine($"Email Sent {e.Email}");
        }
     }
}
