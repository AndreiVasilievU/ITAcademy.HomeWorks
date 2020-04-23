using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11_square
{
    class Circle : Figure
    {
        double radius = 8;
        public override double Area()
        {
            base.Area();
            return 2 * 3.14 * radius;
        }
        public Circle()
        {
            this.name = "Circle";
            this.area = Area();
        }
    }
}
