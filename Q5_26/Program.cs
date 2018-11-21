using System;

namespace Q5_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,meanie=1;
            n = 2;
            int count = 1;

            while (count <= 100)
            {
                while(meanie<=10)
                {
                    string s = checkif.Isprime(n);
                    string ns = Convert.ToString(n);
                    string p = checkif.reverse(ns);
                    string pal = checkif.palindrome(p, ns);
                    if (p == ns && pal == "is a palindrome" && s == "is a prime number")
                    {

                        Console.Write("{0} ", n);
                        count++;
                        n++;
                        meanie++;
                    }
                    else
                    {
                        n++;
                    }
                   
                }
                meanie = 1;
                 Console.WriteLine("");
            }
        }
    }
}
