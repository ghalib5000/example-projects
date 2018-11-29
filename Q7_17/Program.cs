using System;

namespace Q7_17
{
    class Program
    {
        static void Main(string[] args)
        {//                                 banks ammount
            int[] bankammounts = new int[5] { 25, 125, 175, 75, 181 };
            string[] nosafe=new string[5];
            double[,] bor = new double[5, 5];
            double[] bankam = new double[5];
            bor[0, 1] = 100.5;
            bor[0, 4] = 320.5;
            bor[1, 2] = 40;
            bor[1, 3] = 85;
            bor[2, 0] = 125;
            bor[2, 3] = 75;
            bor[3, 0] = 125;
            bor[4, 2] = 125;
            int n = 5, limit = 201, count;
            double borrow;
              Console.Write("enter number of banks:");
              n = int.Parse(Console.ReadLine());
              Console.Write("enter limit amount:");
              limit = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                Console.Write("Bank no#"+i+": "+bankammounts[i]+" ");
                count = bank.countbor(bor, i);
                Console.Write(count+" ");
                for(int y=0;y<n;y++)
                {
                    borrow = bank.loanfind(bor, i,y);
                    for(int t=0;t<n;t++)
                    {
                        if(bor[i,t]==borrow&&borrow!=0)
                        {
                            Console.Write(t+" ");
                        }
                    }
                    if(borrow!=0)
                    Console.Write(borrow+" ");
                }
                Console.WriteLine("");
            }
            nosafe = bank.loansub(n, limit, bankam, bor, bankammounts);
            foreach (string y in nosafe)
            {
                if(y != null)
                Console.WriteLine(y);
            }
        }
    }
}
