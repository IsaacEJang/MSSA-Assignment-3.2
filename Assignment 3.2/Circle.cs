using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._2
{
    internal class Circle
    {
        public double radius { get; set; }

        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }

        public static double operator +(Circle c1,  Circle c2)
        {
            return c1.CalculateArea() + c2.CalculateArea();
        }

        public static double operator -(Circle c1, Circle c2)
        {
            return c1.CalculateArea() - c2.CalculateArea();
        }
    }
}
