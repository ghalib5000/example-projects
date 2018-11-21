using System;
using System.Collections.Generic;
using System.Text;

namespace Q6_3
{
    class arrayclass
    {
        public static  int[] counter(int[] ar)
        {
            int count = 0, n = 0;  //n is the index number of countlist
            int[] countlist = new int[0];
            for (int p = 1; p <= 100; p++)
            {
                for (int a = 0; a < ar.Length; a++)
                {
                    if (p == ar[a])
                    {
                        count++;
                        Array.Resize(ref countlist, n + 1);
                        countlist[n] = count;
                    }
                    if(count!=0&&a==ar.Length-1)
                    {
                        n++;
                        count = 0;
                    }
                }

            }
            return countlist;
        }
        public static int[] newlist(int[] arr)
        {
            int n = 0;  //n is the index number of countlist
            int[] countlist = new int[1];
            for (int p = 1; p <= 100; p++)
            {
                for (int a = 0; a < arr.Length; a++)
                {
                    if (p == arr[a])
                    {
                        countlist[n] = p;
                    }
                    if (countlist[n]!=0 && a == arr.Length - 1)
                    {
                        n++;
                        Array.Resize(ref countlist, n + 1);
                    }
                }
            }
            return countlist;
        }
    }
}
