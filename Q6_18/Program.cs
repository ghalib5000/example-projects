using System;

namespace Q6_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ar;
            int[] nn;
            int n = 0;
            Console.WriteLine("enter numbers(for more than one numbers use ','): ");
            string s = Console.ReadLine();
            ar = s.Split(',');
            int[] num = new int[ar.Length];
            while (n < ar.Length)
            {

                num[n] = Convert.ToInt32(ar[n]);
                n++;
            }
            nn = bubble.sort(num);
            foreach(int i in nn)
            {
                Console.Write(i+" ");
            }
        }
    }
}
