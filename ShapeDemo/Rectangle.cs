using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Rectangle : Shape
    {

        double length,breadth;
        public Rectangle(double l,double b)
        {
            this.length = l;
            this.breadth = b;
            
        }
        public override double Area()
        {
          return length*breadth;
        }
    }
}
