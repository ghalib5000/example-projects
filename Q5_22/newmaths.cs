using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_22
{
    class newmaths
    {
        public static double babes_method(double n)
        {
            double nextguess=n, lastguess=1;
            while (!((nextguess + 0.01) == lastguess && (nextguess - 0.01) == lastguess))
            {
                nextguess =(lastguess + n / lastguess) / 2;
                if(Math.Abs(nextguess-lastguess)<0.000001)
                {
                    return nextguess;
                }
                lastguess = nextguess;
            }
            return nextguess;
        }
    }
}
