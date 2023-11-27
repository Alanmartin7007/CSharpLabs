using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{
    internal class Customer
    {
        public int CustomerId { get; private set; }
        public string Name { get; set; }
        public string city { get; set; }
        public Customer(int custonmerId)
        {
            CustomerId = custonmerId;
        }
    }
}
