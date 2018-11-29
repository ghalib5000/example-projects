using System;
using System.Collections.Generic;
using System.Text;

namespace Q7_17
{
    class bank
    {
        public static double totalass(int banknum,double[,] bor,int[] bankn)
        {
            double total = bankn[banknum];
            int i =0;
            while(i<5)
            {
                total = total + bor[banknum, i];
                i++;
            }
            return total;
        }
        public static string[] loansub(int n,int limit,double[] bankam,double[,] bor,int[] bankammounts)
        {
            int u = 0, i = 0;
            string[] nosafe=new string[5];
            while (u < n)
            {
                while (i < n)

                {
                    bankam[i] = bank.totalass(i, bor, bankammounts);
                    if (bankam[i] < limit)
                    {
                        nosafe[i] = "bank " + i + "  is unsafe it's ammount is: " + bankam[i];
                        bankam[i] = limit + 1;
                        for (int j = 0; j < 5; j++)
                        {
                            bankam[j] = bankam[j] - bor[j, i];
                            bor[j, i] = 0;
                        }
                    }
                    i++;
                }
                u++;
                i = 0;
            }
            return nosafe;
        }

        public static int countbor(double[,] bor,int banknum)
        {
            int count=0;
            for(int i = 0;i<5;i++)
            {
                if(bor[banknum,i]>0)
                {
                    count++;
                }
            }
            return count;
        }
        public static double loanfind(double[,] bor, int banknum,int y)
        {

            double count = 0;
            for (int i = 0; i <= y; i++)
            {
                if (bor[banknum, y] > 0)
                {
                    count = bor[banknum, y];
                    return count;
                }
            }
            return count;
        }
    }
}
