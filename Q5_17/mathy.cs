using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_17
{
    class mathy
    {
        public static void matrix(int  n)
        {
            Random rand = new Random();
            int i = 1;
            for (; i <= n; i++)
            {
                for (int j=1; j <= n; j++)
                {
                    var rnd = rand.Next(0, 2);
                    Console.Write(rnd + " ");
                }
                
                Console.WriteLine("");
            }
            
        }
    }
}
