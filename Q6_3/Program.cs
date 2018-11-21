using System;

namespace Q6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[0];
            int st = 1, n = 0, p = 0;
          
                while (st <= 100&& st != 0)
                {
                Console.WriteLine("enter number under 100: ");
                st = Convert.ToInt32(Console.ReadLine());
                    Array.Resize(ref nums, n + 1);
                    nums[n] = st;
                    n++;
                    if(st>100)
                    {
                        throw new Exception("you did not entered a correct number");
                    }
                }
            Console.WriteLine();
            int[] numcount = arrayclass.counter(nums);
                    int[] nlist = arrayclass.newlist(nums);
                    while (p < numcount.Length)
                    {
                        Console.WriteLine("{0} number occurs: {1}", nlist[p], numcount[p]);
                        p++;
                    }
        }
    }
}

