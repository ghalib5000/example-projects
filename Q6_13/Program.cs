﻿using System;

namespace Q6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ar;
            
            int st = 0,n=0;
            Console.WriteLine("enter numbers to exclude(for more than one numbers use ','): ");
            string s = Console.ReadLine();
            ar = s.Split(',');
            int[] num = new int[ar.Length];
            while (n<ar.Length)
            {
                
                num[n] = Convert.ToInt32(ar[n]);
                n++;
            }
            st = main.getrandom(num);
            Console.WriteLine(st);
        }
    }
}
