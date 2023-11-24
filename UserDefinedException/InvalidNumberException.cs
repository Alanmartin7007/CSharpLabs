using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedException
{
    internal class InvalidNumberException : ApplicationException
    {
        public InvalidNumberException() { }

        public override Exception GetBaseException()
        {
            return base.GetBaseException();
        }
    }
}
