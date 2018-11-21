using System;

namespace Q5_31
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Console.WriteLine("enter number: ");
            name = Console.ReadLine();
            int even = credit.doublecheck(name);
            int odd = credit.oddcheck(name);
            Console.WriteLine("number {0}", credit.isvalid(even,odd));
        }
    }
}
