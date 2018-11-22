using System;
using System.Collections.Generic;
using System.Text;

namespace Q6_11
{
    class newmaths
    {
        public static double meanie(double[] arr)
        {
            int i = 0;
            double meanie = 0;
            while(i<10)
            {
                meanie = meanie + arr[i];
                i++;
            }
            meanie = meanie/ 10;
            return meanie;
        }
        public static double SD(double[] ar, double m)
        {
            double sd,tot=0;
           for(int i=0;i<10;i++)
            {
                tot = tot + Math.Pow(ar[i] - m, 2);
            }
            sd = Math.Sqrt(tot / 9);
            return sd;
        }
    }
}
