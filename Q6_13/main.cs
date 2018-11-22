using System;
using System.Collections.Generic;
using System.Text;

namespace Q6_13
{
    class main
    {
        public static int getrandom(params int[] num)
        {
            Random r = new Random();
            int i = 0;
            int rand = r.Next(0, 9);
            while(i<num.Length)
            {
                if(rand==num[i])
                {
                    rand = r.Next(0, 9);
                    i = -1;
                }
                i++;
            }
            return rand;
        }
    }
}