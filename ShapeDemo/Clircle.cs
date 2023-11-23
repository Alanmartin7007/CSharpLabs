using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Clircle : Shape
    {
       
        double Radius;
        public Clircle(double radius)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius*Radius;
            
        }
    }
}
