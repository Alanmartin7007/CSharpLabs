using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    delegate void OrderEventHandler();
   
    internal class Order
    {

        //public event OrderEventHandler Oncreated;
        //public event EventHandler Oncreated;
        public event EventHandler<OrderEventsArgs> Oncreated;
        public void Create(string email, long phno)
        {
            Console.WriteLine("ORDER PLACED");
            //Email.Send();
            //SMS.Send();
            if (Oncreated != null)
            {
                Oncreated(this, new OrderEventsArgs
                {
                    Email = email,
                    Phone = phno
                });
            }
        
        }
    }
}
