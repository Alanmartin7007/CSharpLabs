using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Trapezium : Shape
    {
        double pa, pb, height;
        public Trapezium(double a,double b,double h)
        {
            this.pa = a;
            this.pb = b;
            this.height = h;

        }
        public override double Area()
        {
            return .5 * (pa + pb) * height;
        }
    }
}
