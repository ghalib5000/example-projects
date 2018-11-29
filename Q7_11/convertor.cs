using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_11
{
    class convertor
    {
        public static int[,] dectobin(int a)
        {//if divided value is greater then int.pasre(value) then the is 1 remainder
            double rem = a, r;
            int i = 2, j = 2;
            int[,] tab = new int[3, 3];
            while (i >= 0)
            {
                while (j >= 0)
                {
                    if (rem == 1)
                    {
                        tab[i, j] = 1;
                        return tab;
                    }
                    else if (rem % 2 == 0)
                    {
                        rem = rem / 2;
                        tab[i, j] = 0;
                    }
                    else if (rem % 2 != 0)
                    {
                        rem = (rem - 1) / 2;
                        tab[i, j] = 1;
                    }
                    j--;
                }
                i--;
                j = 2;
            }
            return tab;
        }    
        public static char[,] numtochar(int[,] a)
        {
            char[,] ht = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(a[i,j]==0)
                    {//head
                        ht[i, j] = 'H';
                    }
                    else if (a[i, j] == 1)
                    {//tail
                        ht[i, j] = 'T';
                    }
                }
            }
            return ht;
        }
    }
}
   

