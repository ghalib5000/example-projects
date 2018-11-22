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
            while (n <= b)
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
        public static int[] posfinder(string s)
        {
            int[] slots = new int[s.Length];
            for (int i=0;i<s.Length;i++)
            {
                if (s[i] == 'L')
                {
                    slots[i] = 0;
                }
                else if (s[i] == 'R')
                {
                    slots[i] = 1;//THE NUMBER OF TIMES R APPEARS
                }
            }
            return slots;
        }
       /* public static int[] finale(int[] ar)
        {
            int[] olist = new int[ar.Length];
            for(int i=0;i<ar.Length;i++)
            {

            }
        }*/
        
    }
}
