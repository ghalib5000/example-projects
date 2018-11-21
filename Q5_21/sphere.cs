using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_21
{
    class sphere
    {
        public static double radians(double n)
        {
            double d = (Math.PI / 180) * n;
            return d;
        }
        public static double finder(double x1 ,double x2 ,double y1, double y2)
        {
            double  er = 6371.01;
            double d =er*( Math.Acos((Math.Sin(x1) * Math.Sin(x2)) + (Math.Cos(x1) * (Math.Cos(x2) * Math.Cos(y1 - y2)))));
            return d;
        }
    }
}
