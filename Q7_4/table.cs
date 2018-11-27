using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_4
{
    class table
    {
        public static int summer(int[,] days)
        {
            int sum = 0, s2 = 0;
            int[] d = new int[7];
            for (int p = 0; p < 8; p++)
            {
                for (int i = 0; i < 8; i++)//
                {
                    for (int j = 0; j < 7; j++)
                    {
                        s2 = s2 + days[i, j];
                    }
                    //   Console.WriteLine(s2);//sum
                    if (s2 > sum)
                    {
                         for(int u=0;u<7;u++)
                        {
                            d[u] = days[i, u];
                        }
                        sum = s2;
                        s2 = 0;
                    }
                    s2 = 0;
                }                        //
                s2 = 0;
                int[] d2 = new int[7];
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        s2 = s2 + days[i, j];
                        d2[j] = days[i, j];
                    }
                    if ((s2 == sum) && (d2[0] == d[0]  && d2[1] == d[1] && d2[2] == d[ 2] && d2[3] == d[ 3] && d2[4] == d[ 4] && d2[5] == d[ 5] && d2[6] == d[ 6]))
                    {
                        for (int u = 0; u < 7; u++)
                        {
                            days[i, u] = 0;
                            s2 = 0;
                        }
                    }
                    s2 = 0;
                }
            }
            return sum;
        }
    }
}
