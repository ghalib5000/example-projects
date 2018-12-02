using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_21
{
    class city
    {
        public static double distance(double x1, double x2, double y1, double y2)
        {
            double dist = 0;
            dist = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return dist;
        }
    }
}
