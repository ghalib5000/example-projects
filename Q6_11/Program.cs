using System;

namespace Q6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double st = 0;
            int n =0;
            double[] ar = new double[10];
            while (n < 10)
            {
                Console.WriteLine("enter 10 numbers: ");
                st = Convert.ToDouble(Console.ReadLine());
                ar[n] = st;
                n++;
            }
            double mean = newmaths.meanie(ar);
            double sd = newmaths.SD(ar, mean);
            Console.WriteLine("the mean is: "+mean);
            Console.WriteLine("the SD is: " + sd);
        }
    }
}
