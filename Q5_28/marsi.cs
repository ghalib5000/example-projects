using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_28
{
    class marsi
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
        public static string p2checker(int n)
        {
            string res="";
            if ((n < (Math.Pow(2, n)-1))) 
            {
                res = "is mersenne prime";
            }
            else
            {
                res = "is not mersenne prime";
            }
            return res;
        }
    }
}
