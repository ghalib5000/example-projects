using System;

namespace Q5_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, meanie = 1;
            n = 2;
            int count = 1;

            while (count <= 100)
            {
                while (meanie <= 10)
                {
                    string s = main.Isprime(n);
                    string ns = Convert.ToString(n);
                    string p = main.reverse(ns);
                    string pal = main.palindrome(p, ns);
                    string s2 = main.Isprime(p);
                    if (s == "is a prime number"&&s2== "is a prime number"&&pal== "is not a palindrome")
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
