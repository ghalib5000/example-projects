using System;
using System.Collections.Generic;
using System.Text;

namespace Q6_21
{
    class MRbean
    {
        public static string slots(int b)
        {
            string slotlist = "";
            Random r = new Random();
            int n = 0;
            while (n <= b-1)
            {
                int rand = r.Next(0, 2);
                if (rand == 0)
                {
                    slotlist = slotlist + 'R';
                }
                else if (rand == 1)
                {
                    slotlist = slotlist + 'L';
                }
                n++;
            }
            return slotlist;
        }
        public static int[] posfinder(string s)//string s here is LLLRRRLRL(similar to this)
        {
            int count=0;
            int[] ballslot = new int[s.Length];
            for (int i=0;i<s.Length;i++)
            {
                if (s[i] == 'R')
                {
                    count++;//THE NUMBER OF TIMES R APPEARS(each increment increases it's position)
                }
            }
            ballslot[count-1] = 1;
            return ballslot;
        }
    }
}
