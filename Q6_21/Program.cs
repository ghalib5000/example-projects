using System;

namespace Q6_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string sl = "";
            int nofballs,st=0,no_of_slots;
            Console.WriteLine("Enter number of balls to drop:");
            nofballs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of slots:");
            no_of_slots = Convert.ToInt32(Console.ReadLine());
            int[] countdb = new int[no_of_slots];//count db has all the position of L and R
            string[] test = new string[no_of_slots];
            for (int p = 0; p < nofballs; p++)
            {
                sl = MRbean.slots(no_of_slots);//FINDS THE LRLR OF SLOTS
                int[] count = MRbean.posfinder(sl); // count is the position R appears in "ONE" line
                Console.WriteLine(sl);
                for (int q = 0; q < count.Length; q++)
                {
                    countdb[q] = countdb[q] + count[q];
                }
            }
            Console.WriteLine("");
            for(int e=1;e<=no_of_slots;e++)
            Console.Write(e);
            Console.WriteLine("");
            st = nofballs;
            while(st>0)
            {
                for(int y=0;y<countdb.Length;y++)
                {
                    if(st==countdb[y])
                    {
                        Console.Write("0");
                        countdb[y] = countdb[y] - 1;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
                st--;
            }
            for (int e = 1; e <= no_of_slots; e++)
                Console.Write(e);
            Console.WriteLine("");
        }
    }
}
