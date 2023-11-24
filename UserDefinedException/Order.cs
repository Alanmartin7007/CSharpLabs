using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    internal class Order
    {
        public  void Create()
        {
            Console.WriteLine("ORDER PLACED");
            Email.Send();
            SMS.Send();

        }
    }
}
