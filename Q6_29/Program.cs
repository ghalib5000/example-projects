using System;

namespace Q6_29
{
    class Program
    {
        static void Main(string[] args)
        {//SPADE = 1 HEART = 2 CLUBS = 3 DIAMONDS = 4
            int[] numdeck = new int[13];
            int[] typedeck = new int[4];
            int n1 = 1, n2 = 2, count = 0,cardnum =0,cardtype = 0;
            string cardno = "", cardtp = "";
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cardnum = cards.cardnum(j);
                    cardtype = cards.cardtype(i);
                    cardno = cards.numfind(cardnum);
                    cardtp = cards.typefind(cardtype);
                    numdeck[j-1] = cardnum;
                    typedeck[i-1] = cardtype;
                      Console.WriteLine("{0} of {1}", cardno, cardtp);
                }
            }
            while (cardnum < 14)
            {
                for (; n2 < 7; n2++)
                {
                    if (n2 != n1)
                    {
                        count++;
                        Console.WriteLine("  " + n1 + "," + n2);}
                }
                n2 = n1;
                n1++;
            }
            Console.WriteLine("the max number is: " + count);
            
        }
    }
}
