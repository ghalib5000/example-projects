using System;

namespace Q6_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string sl = "",a="";
            int nofballs,st=0,no_of_slots;
            Console.WriteLine("Enter number of balls to drop:");
            nofballs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of slots:");
            no_of_slots = Convert.ToInt32(Console.ReadLine());
            int[] countdb = new int[no_of_slots+1];//count db has all the position of L and R
            for (int p = 0; p < nofballs; p++)
            {
                sl = MRbean.slots(no_of_slots);//FINDS THE LRLR OF SLOTS
                int[] count = MRbean.posfinder(sl);
                Console.WriteLine(sl);
                for(int q=0;q<count.Length;q++)
                {
                    countdb[q] = countdb[q] + count[q];
                }
                foreach(int i in countdb)
                Console.Write(i);
                Console.WriteLine("");
            }
            
            
        }
    }
}
