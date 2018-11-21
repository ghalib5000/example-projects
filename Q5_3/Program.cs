using System;

namespace Q5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 ="";
            var n2 ="";
            int st;
            Console.WriteLine("enter number: ");
            n1 = Console.ReadLine();
            Console.WriteLine("enter number to find reverse(1) palindrome(2): ");
            st = Convert.ToInt32(Console.ReadLine());
            if (st == 1)
            {
                n2 = main.reverse(n1);
                Console.WriteLine(n2);
            }
            else if(st==2)
            {
                n2 = main.reverse(n1);
                if(n1==n2)
                Console.WriteLine("it is a palindrome");
                else
                Console.WriteLine("it is not a palindrome");
            }
        }
    }
}
