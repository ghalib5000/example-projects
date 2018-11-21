using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_23
{
    class triangle
    {
        public static double distance(double x1, double y1, double x2, double y2)
        {
            double d;
            d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return d;
        }
        public static double angle(double a,double b,double c)
        {
            double ang;
            ang = Math.Acos(((a*a)-(b*b)-(c*c))/(-2*b*c) );
            return ang;
        }
        public static double degrees(double i)
        {
            double d;
            d = (i * 180) / Math.PI;
            return d;
        }
    }
}
