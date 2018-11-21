using System;

namespace Q5_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, p=2  ;
            Console.WriteLine("  P    2^p-1");
            while(p<=32)
            {
                string checkprim = marsi.Isprime(p);
                if(checkprim =="is a prime number")
                {
                    string mars = marsi.p2checker(p);
                    if(mars == "is mersenne prime")
                    {
                        Console.WriteLine("  {0}      {1}",p, (Math.Pow(2, p) - 1));
                    }
                }
                p++;
            }
        }
    }
}
