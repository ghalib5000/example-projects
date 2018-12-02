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
        public static double minum(double[] d2)
        {
            double n = 0;
            double[] d=new double[d2.Length];
            for(int i=0;i<d2.Length;i++)
            {
                d[i] = d2[i];
            }
            for (int i = 0; i < d.Length - 1; i++)
            {
                if (d[i] < d[i + 1])
                {
                    n = d[i];
                    d[i+1] = n;
                }
            }
            return n;
        }
    }
}
