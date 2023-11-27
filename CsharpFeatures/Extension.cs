using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeatures
{

    internal static class Extension
    {
        public static int ToNumber(this string number)
        {
            return Convert.ToInt32(number);
        }
    }
}
