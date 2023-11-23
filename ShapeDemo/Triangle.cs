using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Triangle : Shape
    {
        double heigth, breath;
        public Triangle( double h, double b)
        {
            this.heigth = h;
            this.breath = b;
        }
        public override double Area()
        {
            return .5 * heigth * breath;
        }
    }
}
