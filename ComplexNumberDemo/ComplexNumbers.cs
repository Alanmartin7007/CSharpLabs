using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberDemo
{
    internal class ComplexNumbers
    {
        //fields
        int real,imaginary;
        public ComplexNumbers(int real,int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static ComplexNumbers operator +(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            ComplexNumbers cn3 = new ComplexNumbers(cn1.real + cn2.real, cn1.imaginary + cn2.imaginary);
            return cn3;
        }
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }

    }
}
