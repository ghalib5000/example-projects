using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_29
{
    class twincheck
    {
        public static string Isprime(int num)
        {
            string result = "";
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    result = "not a prime number";
                    return result;
                }
            }
            result = "is a prime number";
            return result;
        }
    }
}
