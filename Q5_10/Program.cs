using System;

namespace Q5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("enter number: ");
            i = Convert.ToInt32(Console.ReadLine());
            string check = checkif.Isprime(i);
            Console.WriteLine(check);
        }
    }
}
