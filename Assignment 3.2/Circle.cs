using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._2
{
    internal class Circle
    {
        public double Radius { get; set; }

        public double Area { get; set; }

        public double CalculateArea()
        {
            Area = this.Radius * this.Radius * Math.PI;
            return Area;
        }

        public double CalculateRadius()
        {
            Radius = Math.Sqrt(Area / Math.PI);
            return Radius;
        }
        public static Circle operator +(Circle c1,  Circle c2)
        {
            Circle cnew = new Circle();
            cnew.Area = c1.Area + c2.Area;
            cnew.CalculateRadius();
            return cnew;
        }

        public static Circle operator -(Circle c1, Circle c2)
        {
            if (c1.Radius >= c2.Radius)
            {
                Circle cnew2 = new Circle();
                cnew2.Area = c1.Area - c2.Area;
                cnew2.CalculateRadius(); 
                return cnew2;
            }

            if (c1.Radius < c2.Radius)
            {
                Circle cnew3 = new Circle();
                cnew3.Area = c2.Area - c1.Area;
                cnew3.CalculateRadius();
                return cnew3;
            }

            return null;// for syntax. convered bases with equaility functions

        }
    }
}
