using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11_square
{
    class Square : Figure
    {
        double side = 6;
        public override double Area()
        {
            base.Area();
            return side * side;
        }
        public Square()
        {
            this.name = "Square";
            this.area = Area();
        }
    }
}
