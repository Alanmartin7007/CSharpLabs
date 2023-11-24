
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class SMS
    {
        public static void Sent(object sender , OrderEventsArgs e)
        {
            Console.WriteLine($"SMS sent {e.Phone}");
        }
    }
}
