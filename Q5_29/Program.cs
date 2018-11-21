using System;

namespace Q5_29
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1, i2;
            i1 = 2;
            while(i1<1000)
            {
                string i1res = twincheck.Isprime(i1);
                if(i1res== "is a prime number")
                {
                    i2 = i1 + 2;
                    string i2res = twincheck.Isprime(i2);
                    if(i2res== "is a prime number")
                    {
                        Console.WriteLine("({0} , {1}) ", i1, i2);
                       
                    }
                }
                i1++;
            }
        }
    }
}
