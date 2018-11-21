using System;
using System.Collections.Generic;
using System.Text;

namespace Q5_27
{
    class main
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
        public static string palindrome(string n, string i)
        {
            if (n == i)
                return "is a palindrome";
            else
                return "is not a palindrome";

        }
        public static string Isprime(string numb)
        {
            int num = Convert.ToInt32(numb);
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
        public static string reverse(string num)
        {
            string n = "";
            int a = num.Length;
            int i = 1;
            while (i <= a)
            {
                n = n + num[a - 1];
                a--;
            }
            return n;
        }
    }
}
