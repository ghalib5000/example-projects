using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_14
{
    class main
    {
        public static double m(int i)
        {
            int p = 1;
            double a,b,c=0;
            for(;p<=i;p++)
            {
                a = Math.Pow(-1, (p + 1));
                b = (2 * p) - 1;
                c = c + (a / b);
            }
            return c*4;
        }
    }
}
