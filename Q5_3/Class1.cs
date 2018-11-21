using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_3
{
    class main
    {
        public static string reverse(string num)
        {
            string n = "";
            int a = num.Length;
            int i = 1;
            while(i<=a)
            {
                n = n + num[a-1];
                a--;
            }
        return n;
        }
      
    }
}
