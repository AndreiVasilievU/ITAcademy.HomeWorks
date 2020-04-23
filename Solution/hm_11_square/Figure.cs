using System;
using System.Collections.Generic;
using System.Text;

namespace hm_11_square
{
    class Figure
    {
        public string name { get; set; }
        public double area { get; set; }
        public virtual double Area()
        {
            return area ;
        }
    }
}
