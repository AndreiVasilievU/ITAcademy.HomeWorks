using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11_square
{
    class Triangle : Figure 
    {
        double side = 4;
        double high = 6;
        public override double Area()
        {
            base.Area();
            return (side * high) / 2;
        }
        public Triangle()
        {
            this.name = "Triangle";
            this.area = Area();
        }
    }
}
